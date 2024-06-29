# ErgodicMage Result
This package contains a simple implementations of the Result Pattern, Guard Clauses and using Result to reduce exceptions.

## Result Types
```
public readonly record struct Result (bool Success, string ErrorMessage, Exception? Exception)
public readonly record struct Result<T> (bool Success, string ErrorMessage, Exception? Exception, T Value)
```

### Example
```
public async Task<Result<string>> DoWorkflow(string? workflow, CancellationToken token = default)
{
    Result result = GuardClause.NullOrWhiteSpace(workflow);
    if (!result.Success) return result;

    Result<Workflow> resultWorkflow = await GetWorkflow(workflow!, token);
    if (!resultWorkflow.Success) return Result.Error($"Workflow {workflow} not found");

    return await Result<string>.TryAsync(async (Workflow workflow, CancellationToken token) =>
    {
        return await DoWork(workflow, token);
    },
    resultWorkflow.Value, token);
}
```

## Guard Clauses
Null and empty string guard clauses
```
public static Result Null(object? input, string? parameterName = null, string? message = null)
public static Result Null(this Result result, object? input, string? parameterName = null, string? message = null)
public static Result NullOrEmpty(string? input, string? parameterName = null, string? message = null)
public static Result NullOrEmpty(this Result result, string? input, string? parameterName = null, string? message = null)
public static Result NullOrWhiteSpace(string? input, string? parameterName = null,  string? message = null)
```

Minumum and Maximum for any IComparable. Built in type provided: short, int, long, float, double and decimal.
```
public static Result Minimum<T>(T input, T minimum, string? parameterName = null, string? message = null) where T : struct, IComparable
public static Result Minimum<T>(this Result result, T input, T maximum, string? parameterName = null, string? message = null) where T : struct, IComparable
public static Result Maximum<T>(T input, T maximum, [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null) where T : struct, IComparable
public static Result Maximum<T>(this Result result, T input, T maximum, string? parameterName = null, string? message = null) where T : struct, IComparable
```

## Result exception handlers
