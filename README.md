# The Agent-First Papers

**Software has a second reader.**

Most repositories are designed around the cost of human comprehension. Agents change that cost model, but they do not remove it.

This repository explores a practical question:

> **What does software look like when agents are treated as first-class participants in the development loop?**

The work here is experimental. Every claim should eventually have one of three things behind it: **a measurement, a reproducible experiment, or an explicit hypothesis.**

## What this is

- **The Second Reader** is the thesis: code now has another reader and operator besides the human developer.
- **The Agent-First Papers** is the research series: papers, field notes, experiments, and design patterns.
- **SCOPE** is the architectural model emerging from those experiments. It is not a framework and it is not finished.

The current working idea is simple: a capability should expose enough local context for an agent to understand, change, and verify it without reconstructing the whole repository.

```text
Capability boundary
├── context
├── implementation
└── verification
```

## First result: context locality

The first experiment compares two tiny .NET console calculators. Both start with addition. Claude Code receives the same task: add division, preserve addition, handle division by zero, and add tests.

Across **5 runs per variant**, both variants passed the external validation in all runs. The interesting difference happened before the first edit.

| Median | Conventional | Agent-first | Reduction |
|---|---:|---:|---:|
| Files consulted before editing | 11 | 6 | 45.5% |
| Directories consulted before editing | 7 | 4 | 42.9% |
| Context operations before editing | 13 | 10 | 23.1% |
| Total elapsed time | 62.89 s | 57.239 s | 9.0% |
| Cost | $0.244 | $0.210 | 14.0% |

The result does **not** show that agent-first architecture makes an agent dramatically faster. It suggests something narrower and more useful:

> **A locally self-describing capability can reduce the repository surface an agent needs to reconstruct before acting.**

The project is deliberately small. The next question is whether that effect survives or grows in a repository with tens of capabilities.

## The second bottleneck: human verification

Making an agent cheaper to operate only solves half of the loop. If agents can generate changes faster than humans can establish confidence in them, review becomes the dominant cost.

SCOPE therefore has two directions:

```text
Human -> Agent    Context locality
Agent -> Human    Verification locality
```

The working question for the second direction is:

> **Can we reduce the cost of reviewing agent-generated code without reducing the quality of the decision?**

The current hypothesis is that the raw diff should stop being the only review interface. Agent-authored changes should carry an evidence bundle: behavioural claims, preserved invariants, deterministic test results, boundary changes, unresolved assumptions, and a small set of locations where human semantic judgment is still required.

See [`patterns/verification-locality.md`](patterns/verification-locality.md) and [`patterns/proof-carrying-change.md`](patterns/proof-carrying-change.md).

## Repository map

```text
papers/       Arguments and field notes
experiments/  Reproducible comparisons and raw methodology
patterns/     Design hypotheses that emerge from the evidence
examples/     Small reference implementations
```

Start here:

- [`papers/01-the-second-reader/field-note-01-context-locality.md`](papers/01-the-second-reader/field-note-01-context-locality.md)
- [`experiments/001-small-context-locality/README.md`](experiments/001-small-context-locality/README.md)
- [`patterns/local-context.md`](patterns/local-context.md)
- [`ROADMAP.md`](ROADMAP.md)

## Principles of the project

We care about the work surrounding code generation: context reconstruction, change locality, verification surface, and human review cost.

We do not use a single synthetic “agent score”. Metrics remain separate so uncomfortable results stay visible.

We also publish limitations. A result that only holds in a toy repository is still useful if it is described as a toy-repository result.

## Reproducing experiment 001

Requirements:

- Git
- Python 3.9+
- .NET 10 SDK
- Claude Code, authenticated

Then:

```bash
cd experiments/001-small-context-locality
cp config.example.json config.json
python3 runner/run_experiment.py --all
python3 runner/summarize_results.py
```

Edit the repository paths in `config.json` if you want to test your own variants. The checked-in variants are ready to use as baselines.

## Status

This is research in public, not a finished methodology.

The next planned experiment scales the same idea to roughly 50 capabilities and introduces explicit measurements for **boundary leakage** and **context ratio**.

## Licensing

Code is available under the MIT License. Written papers, diagrams, and editorial content are released under CC BY 4.0 unless noted otherwise. See [`CONTENT_LICENSE.md`](CONTENT_LICENSE.md).
