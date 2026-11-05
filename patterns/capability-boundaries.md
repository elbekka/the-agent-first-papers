# Capability Boundaries

**Status:** hypothesis.

Prefer repository boundaries that group behavior an agent usually needs to understand together.

A capability boundary can contain:

```text
Feature/
├── CLAUDE.md
├── implementation
└── tests
```

The boundary is cognitive, not necessarily a build boundary. Experiment 001 initially used a separate `.csproj` per capability and created unnecessary mechanical change. The design was corrected so capabilities remain locally understandable without forcing a project boundary for every feature.

> A context boundary does not need to be a compilation boundary.
