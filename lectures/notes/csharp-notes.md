# C# / .NET Notes

## Key Differences from Java
- Top-level statements allowed (no class/Main needed for simple programs)
- `decimal` for money (not double)
- `List<T>` instead of ArrayList
- `string` is immutable (use StringBuilder for heavy modifications)
- Properties instead of getters/setters
- Records for immutable data
- `var` for type inference
- Nullable reference types (`string?`)

## Runtime
- CLR + JIT
- Garbage Collection automatic

## Best Practices
- Prefer `decimal` for financial calculations
- Use `using` for IDisposable
- Prefer interfaces over abstract classes when possible