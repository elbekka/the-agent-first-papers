# Experiments

Experiments are the executable half of the project.

Each experiment should contain the prompt, variants, runner, result summary, and limitations needed to understand or reproduce the claim.

## Review experiments

Future experiments should treat human verification as a measurable part of the development loop. A review experiment should preserve the underlying code change while varying the review interface, so that `diff only` can be compared with an evidence-carrying change.

Primary outcome: **review cost at a fixed decision-quality threshold**, not approval speed in isolation.
