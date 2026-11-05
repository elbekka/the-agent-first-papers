# Patterns

These are working design hypotheses, not commandments.

A pattern belongs here only when we can explain the cost it is trying to reduce, the trade-off it introduces, and the evidence behind it.

## Current hypotheses

- [`local-context.md`](local-context.md) — reduce context reconstruction before an agent acts.
- [`capability-boundaries.md`](capability-boundaries.md) — colocate context, implementation, and verification around a capability.
- [`completion-contracts.md`](completion-contracts.md) — make done observable.
- [`verification-locality.md`](verification-locality.md) — reduce the information a human must reconstruct to review a change.
- [`proof-carrying-change.md`](proof-carrying-change.md) — make agent output arrive with auditable evidence, not only a diff.
