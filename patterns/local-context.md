# Local Context

**Status:** supported by exploratory evidence.

Place the information needed to change a capability close to the capability itself.

A useful local context document answers:

- What does this capability own?
- What contract must remain true?
- What invariants matter?
- Which files normally change together?
- How is the capability verified?
- When is the work complete?

## Intended effect

Reduce **context reconstruction**: the amount of repository exploration required before the first valid edit.

## Trade-off

Local context can become stale. Duplicating global rules into every capability creates another maintenance problem. Local documents should contain genuinely local information and refer upward for global policy.
