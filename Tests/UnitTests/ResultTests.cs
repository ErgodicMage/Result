using ErgodicMage.Result;

namespace UnitTests;

public class ResultTests
{
    string goodString = "Good string";
    string errorString = "Error string";
    string? nullString = default;

    [Fact]
    public void ResultFromValue()
    {
        Result<string> resultString = goodString;

        Assert.Equal(goodString, resultString.Value);
    }

    [Fact]
    public void ResultToValue()
    {
        Result<string> resultString = goodString;
        string value = resultString;

        Assert.Equal(goodString, value);
    }

    [Fact]
    public void CastSuccessResultToResultString()
    {
        Result result = Result.Ok();
        Result<string> resultString = result;

        Assert.True(resultString.Success);
        Assert.True(string.IsNullOrEmpty(resultString.ErrorMessage));
        Assert.Null(resultString.Exception);
        // value will be null because cast doesn't have a value
        Assert.Null(resultString.Value);
    }

    [Fact]
    public void CastErrorResultToResultString()
    {
        Result result = Result.Error(new ArgumentNullException(), errorString);
        Result<string> resultString = result;

        Assert.False(resultString.Success);
        Assert.False(string.IsNullOrEmpty(resultString.ErrorMessage));
        Assert.Equal(errorString, resultString.ErrorMessage);
        Assert.NotNull(resultString.Exception);
        // value will be null because cast doesn't have a value
        Assert.Null(resultString.Value);
    }

    [Fact]
    public void CastFromSuccessResultStringToResult()
    {
        Result<string> resultString = Result<string>.Ok(goodString);
        Result result = resultString;

        Assert.True(result.Success);
        Assert.True(string.IsNullOrEmpty(result.ErrorMessage));
        Assert.Null(result.Exception);
    }

    [Fact]
    public void CastFromErrorResultStringToResult()
    {
        Result<string> resultString = Result<string>.Error(new ArgumentNullException(), errorString);
        Result result = resultString;

        Assert.False(result.Success);
        Assert.False(string.IsNullOrEmpty(result.ErrorMessage));
        Assert.Equal(errorString, result.ErrorMessage);
        Assert.NotNull(result.Exception);
        Assert.IsType<ArgumentNullException>(result.Exception);
    }
}