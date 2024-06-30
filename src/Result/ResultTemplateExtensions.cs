namespace ErgodicMage.Result;

public static class ResultTemplateExtensions
{
    public static Result<T> Convert<T, U>(this Result<U> result)
    where T : class, U
    where U : class
    => result.Success switch
    {
        true => Result<T>.Ok((result.Value as T)!),
        _ => Result<T>.Error(result.ErrorMessage)
    };
}
