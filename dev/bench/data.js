window.BENCHMARK_DATA = {
  "lastUpdate": 1606137751503,
  "repoUrl": "https://github.com/realm/realm-dotnet",
  "entries": {
    "Benchmark": [
      {
        "commit": {
          "author": {
            "email": "4850119+papafe@users.noreply.github.com",
            "name": "Ferdinando Papale",
            "username": "papafe"
          },
          "committer": {
            "email": "noreply@github.com",
            "name": "GitHub",
            "username": "web-flow"
          },
          "distinct": true,
          "id": "e25874a5fda0928046bb2c28335e07afa03d5709",
          "message": "Added different branch for pages",
          "timestamp": "2020-11-23T14:18:47+01:00",
          "tree_id": "325a5dd49c1c5e129cdfa497d2c13359268b6925",
          "url": "https://github.com/realm/realm-dotnet/commit/e25874a5fda0928046bb2c28335e07afa03d5709"
        },
        "date": 1606137742275,
        "tool": "benchmarkdotnet",
        "benches": [
          {
            "name": "PerformanceTests.QueryTests.Count(ObjectCount: 10)",
            "value": 234562.1337890625,
            "unit": "ns",
            "range": "± 2488.773382796491"
          },
          {
            "name": "PerformanceTests.QueryTests.Count(ObjectCount: 100)",
            "value": 233506.85221354166,
            "unit": "ns",
            "range": "± 888.7820950859278"
          },
          {
            "name": "PerformanceTests.QueryTests.Count(ObjectCount: 1000)",
            "value": 243617.56184895834,
            "unit": "ns",
            "range": "± 1234.7770954272298"
          },
          {
            "name": "PerformanceTests.QueryTests.Enumerate(ObjectCount: 10)",
            "value": 38062.152099609375,
            "unit": "ns",
            "range": "± 143.34571004075963"
          },
          {
            "name": "PerformanceTests.QueryTests.Enumerate(ObjectCount: 100)",
            "value": 96259.4970703125,
            "unit": "ns",
            "range": "± 294.7207230987367"
          },
          {
            "name": "PerformanceTests.QueryTests.Enumerate(ObjectCount: 1000)",
            "value": 759136.7513020834,
            "unit": "ns",
            "range": "± 17224.977555927035"
          }
        ]
      }
    ]
  }
}