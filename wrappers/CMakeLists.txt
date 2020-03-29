cmake_minimum_required(VERSION 3.4.0)

set(CMAKE_BUILD_TYPE Debug CACHE STRING "")
project(realm-wrappers)

list(APPEND CMAKE_MODULE_PATH "${CMAKE_CURRENT_SOURCE_DIR}/src/object-store/CMake")

if(CMAKE_SYSTEM_NAME STREQUAL "Linux")
  # set before including RealmCore.cmake which calls FindOpenSSL
  set(OPENSSL_USE_STATIC_LIBS TRUE)
endif()

if(NOT REALM_PLATFORM)
  set(REALM_PLATFORM DotNet)
endif()

include(CompilerFlags)
include(RealmCore)

set(REALM_ENABLE_SYNC OFF CACHE BOOL "")
if(REALM_ENABLE_SYNC)
  if(NOT ANDROID)
    set(REALM_ENABLE_SERVER ON)
  endif()
  add_definitions(-DREALM_ENABLE_SYNC)
endif()

set(CMAKE_CXX_VISIBILITY_PRESET hidden)
set(BUILD_APPLE_FRAMEWORK FALSE)

if(APPLE)
  set(CMAKE_CXX_VISIBILITY_PRESET default)
  set(CMAKE_VISIBILITY_INLINES_HIDDEN TRUE)
  if (CMAKE_SYSTEM_NAME STREQUAL "iOS")
    set(CMAKE_OSX_DEPLOYMENT_TARGET 8.0)
    set(BUILD_APPLE_FRAMEWORK TRUE)
  else()
    set(CMAKE_OSX_DEPLOYMENT_TARGET 10.10)
  endif()
elseif(CMAKE_SYSTEM_NAME MATCHES "^Windows")
  add_definitions(-DWIN32_LEAN_AND_MEAN)
  add_definitions(
    /D_DISABLE_EXTENDED_ALIGNED_STORAGE # https://developercommunity.visualstudio.com/comments/279328/view.html
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
  endif()
endif()

set(REALM_BUILD_LIB_ONLY ON)

add_subdirectory(src/realm-core)
add_subdirectory(src/object-store/src)
add_subdirectory(src)

# force Object Store to use the generic EventLoopSignal implementation
target_compile_definitions(realm-object-store PUBLIC
  REALM_USE_CF=0
  REALM_USE_ALOOPER=0
  REALM_USE_UV=0
)

if(APPLE OR ANDROID)
  # force Object Store to use the generic EventLoopSignal implementation instead of the system one
  # path is relative to object-store/src where add_library(realm-object-store) is called
  target_sources(realm-object-store PRIVATE util/generic/event_loop_signal.cpp)
endif()