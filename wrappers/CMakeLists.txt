cmake_minimum_required(VERSION 3.15.0)

set(CMAKE_BUILD_TYPE Debug CACHE STRING "")
project(RealmDotNet)

# Load dependency info from dependencies.list into REALM_FOO_VERSION variables.
set(DEPENDENCIES_FILE "dependencies.list" CACHE STRING "path to dependencies list")
file(STRINGS ${DEPENDENCIES_FILE} DEPENDENCIES)
message("Dependencies: ${DEPENDENCIES}")
foreach(DEPENDENCY IN LISTS DEPENDENCIES)
    string(REGEX MATCHALL "([^=]+)" COMPONENT_AND_VERSION ${DEPENDENCY})
    list(GET COMPONENT_AND_VERSION 0 COMPONENT)
    list(GET COMPONENT_AND_VERSION 1 VERSION)
    set(${COMPONENT} ${VERSION})
endforeach()

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_CXX_EXTENSIONS OFF)
set(CMAKE_CXX_VISIBILITY_PRESET hidden)

option(REALM_DOTNET_BUILD_CORE_FROM_SOURCE "Build Realm Core from source, as opposed to downloading prebuilt binaries" ON)
if(REALM_DOTNET_BUILD_CORE_FROM_SOURCE)
    set(REALM_BUILD_LIB_ONLY ON)
    set(REALM_ENABLE_SYNC ON)

    add_subdirectory(realm-core EXCLUDE_FROM_ALL)

    # force Object Store to use the generic Scheduler implementation
    target_compile_definitions(ObjectStore PUBLIC
      REALM_USE_CF=0
      REALM_USE_ALOOPER=0
      REALM_USE_UV=0
    )
endif()

# Build as a .framework instead of .dylib
set(BUILD_APPLE_FRAMEWORK OFF)

if(APPLE)
  set(CMAKE_VISIBILITY_INLINES_HIDDEN TRUE)
  if (CMAKE_SYSTEM_NAME STREQUAL "iOS")
    set(CMAKE_OSX_DEPLOYMENT_TARGET 11.0)
    set(BUILD_APPLE_FRAMEWORK TRUE)
    set(CMAKE_XCODE_ATTRIBUTE_VALID_ARCHS[sdk=iphonesimulator*] "i386 x86_64") # Do not build Apple Silicon slices yet
  endif()
elseif(CMAKE_SYSTEM_NAME MATCHES "^Windows")
  add_definitions(/DWIN32_LEAN_AND_MEAN)
  add_compile_options(
      /MP # Enable multi-processor compilation
  )

  # always produce a PDB
  set(CMAKE_CXX_FLAGS_RELEASE "${CMAKE_CXX_FLAGS_RELEASE} /Zi")
  set(CMAKE_SHARED_LINKER_FLAGS_RELEASE "${CMAKE_SHARED_LINKER_FLAGS_RELEASE} /DEBUG /OPT:REF /OPT:ICF")

  if(WINDOWS_STORE)
    set(CMAKE_SHARED_LINKER_FLAGS_DEBUG "${CMAKE_SHARED_LINKER_FLAGS_DEBUG} /nodefaultlib:vccorlibd /nodefaultlib:msvcrtd vccorlibd.lib msvcrtd.lib")
    set(CMAKE_SHARED_LINKER_FLAGS_RELEASE "${CMAKE_SHARED_LINKER_FLAGS_RELEASE} /nodefaultlib:vccorlib /nodefaultlib:msvcrt vccorlib.lib msvcrt.lib")
  else()
    set(CMAKE_SHARED_LINKER_FLAGS_DEBUG "${CMAKE_SHARED_LINKER_FLAGS_DEBUG} /nodefaultlib:libucrtd.lib /defaultlib:ucrtd.lib")
    set(CMAKE_SHARED_LINKER_FLAGS_RELEASE "${CMAKE_SHARED_LINKER_FLAGS_RELEASE} /nodefaultlib:libucrt.lib /defaultlib:ucrt.lib")

    set(CMAKE_MSVC_RUNTIME_LIBRARY "MultiThreaded$<$<CONFIG:Debug>:Debug>")
  endif()
endif()

add_subdirectory(src)
