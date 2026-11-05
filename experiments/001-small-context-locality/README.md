# Experiment 001 — Small-repository context locality

## Question

Does a self-contained capability boundary reduce the repository surface Claude Code needs to inspect before editing?

## Variants

### Conventional

Layered by technical concern:

```text
src/Calculator/
├── Application/
├── Domain/
├── Factories/
└── Validation/

tests/
docs/
```

### Agent-first

Grouped around capabilities:

```text
Features/
└── Add/
    ├── CLAUDE.md
    ├── AddOperation.cs
    └── AddOperationTests.cs
```

Production and test projects are shared. The capability boundary is intentionally **not** a separate compilation boundary.

## Isolation

The runner launches Claude Code with a restricted tool set and project-only settings. User skills and slash commands are disabled. MCP tools and Chrome integration are not available to the run.

The runner also sets `CLAUDE_CODE_DISABLE_AUTO_MEMORY=1` so user auto-memory does not affect the measurement.

## Run

```bash
cp config.example.json config.json
python3 runner/run_experiment.py --all
python3 runner/summarize_results.py
```

Each run gets a fresh clone of its source variant.

## Primary measures

- context operations before first edit;
- unique files consulted before first edit;
- unique directories consulted before first edit;
- time to first edit;
- total elapsed time;
- cost;
- changed-file surface;
- external test result.

No weighted score is calculated.

## Published result

See [`results/summary.md`](results/summary.md).
