# Verification Locality

**Status:** hypothesis.

Agent-first architecture has two directions.

```text
Human -> Agent    Context locality
Agent -> Human    Verification locality
```

Context locality asks how much of the repository an agent must reconstruct before it can act.

Verification locality asks the symmetric question:

> **How much information must a human reconstruct before they can accept or reject the agent's change with confidence?**

The path from a change to evidence that the change is correct should be short, explicit, and close to the behaviour being changed.

## Why this matters

When code generation gets cheaper, review can become the bottleneck.

A pull request that contains a correct 500-line diff can still be expensive if the reviewer must reconstruct architecture, infer invariants, find the relevant tests, and decide which parts of the diff deserve semantic attention.

The goal is not to remove code review. The goal is to stop treating the raw diff as the only useful interface for review.

## Review surface

Working metric:

```text
Review Surface
= the amount of information a human must inspect
  before making a correct accept/reject decision
```

Candidate measurements:

- seconds to accept or reject;
- files opened by the reviewer;
- lines inspected;
- boundary crossings during review;
- questions sent back to the agent;
- code outside the diff consulted for context;
- reviewer confidence;
- defects missed by the review.

A smaller review surface is only better if decision quality is preserved.

## Proof-carrying changes

A useful agent output should contain more than code. It should carry evidence for the claims the change makes.

Example:

```text
CHANGE
Add division

Behaviour changed
- 10 / 2 -> 5
- 10 / 0 -> "Cannot divide by zero."

Behaviour preserved
- addition contract unchanged

Boundaries touched
- Features/Divide/
- Host/Program.cs

Verification
- local tests: PASS
- repository tests: PASS
- external acceptance tests: PASS
- build: PASS

Unexpected boundary changes
- none

Unverified assumptions
- one

Human semantic review suggested
- DivideResult.cs
- Host/Program.cs integration branch
```

The diff remains available, but it is no longer the first or only representation of the change.

## Evidence must not be self-certification

The authoring agent saying `all good` is not evidence.

Prefer evidence from distinct sources:

```text
Author agent
    -> implementation + claims

Deterministic verification
    -> tests + build + contracts + static checks

Independent verifier
    -> challenges claims + identifies uncertainty

Human reviewer
    -> decides on the remaining semantic risk
```

The evidence bundle should distinguish observed facts from agent assertions.

## Local verification contracts

A capability boundary should expose not only how to change the behaviour, but how to prove that the change is acceptable.

Example capability context:

```markdown
## Invariants
- Division never throws for decimal inputs.
- Divide by zero produces a domain failure.
- Console concerns do not enter this capability.

## Verification contract
A change is acceptable when:
- all local tests pass;
- existing Add behaviour is unchanged;
- zero division is covered by an external acceptance test;
- no files outside this capability change unless integration requires it.
```

This makes verification requirements discoverable from the same boundary as the implementation.

## Non-goal

Verification locality is not a justification for approving generated code without inspecting risk.

For security-sensitive, safety-critical, financial, concurrency-heavy, or otherwise high-risk changes, direct code inspection may remain mandatory.

The hypothesis is narrower:

> **Can we reduce the cost of reviewing agent-generated code without reducing the quality of the human decision?**

That question should be measured, not assumed.
