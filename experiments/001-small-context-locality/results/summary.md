# Experiment Summary

## Runs

| | Conventional | Agent-first |
|---|---:|---:|
| Total runs | 5 | 5 |
| Valid runs | 5 | 5 |
| External test success | 100% | 100% |

## Median metrics

| Metric | Conventional | Agent-first | Reduction |
|---|---:|---:|---:|
| Total time (s) | 62.89 | 57.239 | 9.0% |
| Time to first edit (s) | 23.314 | 22.283 | 4.4% |
| Context operations before edit | 13 | 10 | 23.1% |
| Unique files consulted before edit | 11 | 6 | 45.5% |
| Unique directories consulted before edit | 7 | 4 | 42.9% |
| Agent `dotnet test` attempts | 1 | 1 | 0% |
| Cost (USD) | 0.244 | 0.210 | 14.0% |
| Files changed | 6 | 4 | — |
| Lines added | 82 | 113 | — |
| Lines deleted | 3 | 2 | — |

## Per-run navigation observations

| Run | Variant | Total time (s) | Context ops | Files consulted | Directories consulted | Files changed |
|---:|---|---:|---:|---:|---:|---:|
| 1 | conventional | 72.098 | 15 | 11 | 7 | 5 |
| 2 | conventional | 50.043 | 13 | 11 | 7 | 6 |
| 3 | conventional | 62.890 | 14 | 12 | 6 | 6 |
| 4 | conventional | 58.795 | 12 | 10 | 6 | 5 |
| 5 | conventional | 79.308 | 13 | 12 | 7 | 6 |
| 1 | agent-first | 63.824 | 10 | 7 | 5 | 4 |
| 2 | agent-first | 61.278 | 10 | 7 | 4 | 5 |
| 3 | agent-first | 57.239 | 11 | 6 | 4 | 4 |
| 4 | agent-first | 52.248 | 8 | 6 | 4 | 5 |
| 5 | agent-first | 43.849 | 7 | 5 | 4 | 3 |

## Limitations

Five runs per variant are exploratory evidence, not a statistically conclusive result.

Timing includes model/API and host latency.

The variants differ architecturally, so the experiment does not isolate a single causal variable.

`stream-json` only exposes paths visible through tool events; consulted-file counts are lower bounds.

Human review time was not collected in this run set.
