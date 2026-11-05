# Add capability

This directory owns addition behavior.

## Contract

`AddOperation.Execute(left, right)` returns the arithmetic sum of two decimal values.

## Invariants

- Arithmetic uses `decimal`.
- The operation does not read from or write to the console.
- Behavior changes require tests in this directory.
- Changes to addition should remain inside this directory unless the public console flow must change.

## Verification

Run:

```bash
dotnet test Tests/Calculator.Features.Tests.csproj
```

## Completion criteria

- The feature project builds.
- All tests pass.
- Existing addition cases remain valid.
