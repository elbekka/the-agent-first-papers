# Roadmap

## Season 01 — The Second Reader

### 001 — Context locality
**Status:** complete, exploratory.

Question: does colocating context, implementation, and verification reduce the surface an agent must inspect before editing?

### 002 — Context locality at 50 capabilities
**Status:** planned.

Scale both repository designs to roughly 50 comparable capabilities. Add:

- context ratio;
- boundary leakage;
- wrong-boundary reads;
- verification surface;
- human review time.

### 003 — Cross-boundary change
**Status:** planned.

Test a change that legitimately spans several capabilities. The goal is to find where locality stops helping and coordination becomes the dominant cost.

### 004 — Verification cost / proof-carrying changes
**Status:** planned.

Question: **can we reduce the cost of reviewing agent-generated code without reducing decision quality?**

Compare two review interfaces over the same agent-produced changes:

- **A — Diff only:** traditional code diff plus repository context available on demand.
- **B — Evidence bundle:** diff plus behavioural claims, preserved invariants, deterministic verification, boundary report, unresolved assumptions, and suggested semantic review locations.

Measure:

- time to accept/reject;
- files and lines inspected;
- context opened outside the diff;
- reviewer questions;
- correct defects detected;
- false confidence / missed defects;
- final confidence score.

The target is not faster approval. The target is **lower review cost at equal or better decision quality**.

### 005 — Context decay
**Status:** hypothesis.

Measure what happens when local documentation is stale, contradictory, or over-specified. Agent Experience should include the cost of bad context, not only the benefit of good context.
