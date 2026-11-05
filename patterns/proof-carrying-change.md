# Proof-Carrying Change

**Status:** hypothesis.

A code change produced by an agent should arrive with a compact, auditable proof package describing what changed, what was preserved, what was verified, and what still requires human judgment.

The proof package is a review interface, not a replacement for the diff.

## Proposed output

```text
change-evidence/
├── summary.md
├── claims.json
├── verification.json
├── boundary-report.json
└── artifacts/
    ├── test-results/
    └── acceptance-results/
```

`summary.md` should answer five questions quickly:

1. What behaviour changed?
2. What behaviour must remain unchanged?
3. Which boundaries were touched?
4. What evidence was produced independently of the authoring agent?
5. Where is human semantic review still required?

## Claim model

Every important statement in the summary should be classifiable as one of:

- **verified** — backed by deterministic evidence;
- **independently checked** — challenged by a separate verifier;
- **asserted** — stated by the authoring agent but not independently proven;
- **unknown** — unresolved and explicitly surfaced.

A reviewer should never have to infer which category a claim belongs to.

## Design pressure

This pattern changes architecture upstream.

If a repository cannot produce local evidence for a local change, that is information about the architecture: behaviour, tests, contracts, and ownership may be too dispersed to support cheap verification.

The target is not "more documentation". The target is **less reconstruction at review time**.
