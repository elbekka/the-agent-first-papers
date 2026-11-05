# Completion Contracts

**Status:** hypothesis.

Agents benefit from explicit completion criteria that can be checked rather than inferred.

Example:

```text
Completion criteria
- the feature builds;
- local tests pass;
- existing behavior remains valid;
- no unrelated files are modified.
```

The goal is not to micromanage the agent. The goal is to reduce ambiguity at the end of the task, where verification cost accumulates.
