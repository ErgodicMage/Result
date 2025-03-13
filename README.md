# ErgodicMage Result
A simple implementations of the Result Pattern, Guard Clauses and using Result to reduce exceptions.

## Result Types
```
public readonly record struct Result (bool Success, string ErrorMessage, Exception? Exception)
public readonly record struct Result<T> (bool Success, string ErrorMessage, Exception? Exception, T Value)
```

### Example
```
private readonly record struct Workflow(string Name, int Jobs);

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

private static async Task<Result<Workflow>> GetWorkflow(string workflow, CancellationToken? token = default)
    => new Workflow(workflow, 1);

private static async Task<Result<string>> DoWork(Workflow workflow, CancellationToken? token = default)
{
    Result result = GuardClause.Null(workflow);
    if (!result.Success) return result;
    await Task.Delay(1000);
    return workflow.Name;
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
public static Result NullOrWhiteSpace(this Result result, string? input, string? parameterName = null, string? message = null)
```

Minumum and Maximum for any IComparable. Built in types provided: short, int, long, float, double and decimal.
```
public static Result Minimum<T>(T input, T minimum, string? parameterName = null, string? message = null) where T : struct, IComparable
public static Result Minimum<T>(this Result result, T input, T maximum, string? parameterName = null, string? message = null) where T : struct, IComparable
public static Result Maximum<T>(T input, T maximum, [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null) where T : struct, IComparable
public static Result Maximum<T>(this Result result, T input, T maximum, string? parameterName = null, string? message = null) where T : struct, IComparable

public static Result Minimum(short input, short minimum, string? parameterName = null, string? message = null)
public static Result Minimum(this Result result, short input, short minimum, string? parameterName = null, string? message = null)
public static Result Minimum(int input, int minimum, string? parameterName = null, string? message = null)
public static Result Minimum(this Result result, int input, int minimum, string? parameterName = null, string? message = null)
public static Result Minimum(long input, long minimum, string? parameterName = null, string? message = null)
public static Result Minimum(this Result result, long input, long minimum, string? parameterName = null, string? message = null)
public static Result Minimum(float input, float minimum, string? parameterName = null, string? message = null)
public static Result Minimum(this Result result, float input, float minimum, string? parameterName = null, string? message = null)
public static Result Minimum(double input, double minimum, string? parameterName = null, string? message = null)
public static Result Minimum(this Result result, double input, double minimum, string? parameterName = null, string? message = null)
public static Result Minimum(decimal input, decimal minimum, string? parameterName = null, string? message = null)
public static Result Minimum(this Result result, decimal input, decimal minimum, string? parameterName = null, string? message = null)

public static Result Maximum(short input, short maximum, string? parameterName = null, string? message = null)
public static Result Maximum(this Result result, short input, short maximum, string? parameterName = null, string? message = null)
public static Result Maximum(int input, int maximum, string? parameterName = null, string? message = null)
public static Result Maximum(this Result result, int input, int maximum, string? parameterName = null, string? message = null)
public static Result Maximum(long input, long maximum, string? parameterName = null, string? message = null)
public static Result Maximum(this Result result, long input, long maximum, string? parameterName = null, string? message = null)
public static Result Maximum(float input, float maximum, string? parameterName = null, string? message = null)
public static Result Maximum(this Result result, float input, float maximum, string? parameterName = null, string? message = null)
public static Result Maximum(double input, double maximum, string? parameterName = null, string? message = null)
public static Result Maximum(this Result result, double input, double maximum, string? parameterName = null, string? message = null)
public static Result Maximum(decimal input, decimal maximum, string? parameterName = null, string? message = null)
public static Result Maximum(this Result result, decimal input, decimal maximum, string? parameterName = null, string? message = null)
```

OutOfRange for any IComparable. Built in types provided: short, int, long, float, double and decimal.
```
public static Result OutOfRange<T>(T input, T rangeFrom, T rangeTo, string? parameterName = null, string? message = null) where T : struct, IComparable
public static Result OutOfRange<T>(this Result result, T input, T rangeFrom, T rangeTo, string? parameterName = null, string? message = null) where T : struct, IComparable

public static Result OutOfRange(short input, short rangeFrom, short rangeTo, string? parameterName = null, string? message = null)
public static Result OutOfRange(this Result result, short input, short rangeFrom, short rangeTo, string? parameterName = null, string? message = null)
public static Result OutOfRange(int input, int rangeFrom, int rangeTo, string? parameterName = null, string? message = null)
public static Result OutOfRange(this Result result, int input, int rangeFrom, int rangeTo, string? parameterName = null, string? message = null)
public static Result OutOfRange(long input, long rangeFrom, long rangeTo, string? parameterName = null, string? message = null)
public static Result OutOfRange(this Result result, long input, long rangeFrom, long rangeTo, string? parameterName = null, string? message = null)
public static Result OutOfRange(float input, float rangeFrom, float rangeTo, string? parameterName = null, string? message = null)
public static Result OutOfRange(this Result result, float input, float rangeFrom, float rangeTo, string? parameterName = null, string? message = null)
public static Result OutOfRange(double input, double rangeFrom, double rangeTo, string? parameterName = null, string? message = null)
public static Result OutOfRange(this Result result, double input, double rangeFrom, double rangeTo, string? parameterName = null, string? message = null)
public static Result OutOfRange(decimal input, decimal rangeFrom, decimal rangeTo, string? parameterName = null, string? message = null)
public static Result OutOfRange(this Result result, decimal input, decimal rangeFrom, decimal rangeTo, string? parameterName = null, string? message = null)
```

## Result exception handlers

