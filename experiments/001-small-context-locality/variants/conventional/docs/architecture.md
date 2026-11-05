# Architecture

Calculator organized in technical layers, with dependencies pointing toward the domain.

```text
Program
  -> Application
      -> Factories
          -> Domain
      -> Validation
```

## Extending with a new operation

1. Add a value to `OperationType`.
2. Create a domain class implementing `IOperation`.
3. Register the new case in `OperationFactory.Create`.
4. Update the console flow when user selection is required.
5. Add tests in `Calculator.Tests`.
