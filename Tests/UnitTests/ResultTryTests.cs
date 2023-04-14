using Newtonsoft.Json.Linq;

namespace UnitTests;

public class ResultTryTests
{
    [Fact]
    public void TryActionNoExceptionSuccess()
    {
        Result result = Result.Try(() => { });

        Assert.True(result.Success);
    }

    [Fact]
    public void TryActionExceptionError()
    {
        Result result = Result.Try(() => throw new Exception("Action throwing Exception"));

        Assert.False(result.Success);
        Assert.NotNull(result.Exception);
        Assert.Equal("Action throwing Exception", result.ErrorMessage);
    }

    [Fact]
    public void TryActionPNoExceptionSuccess()
    {
        Result result = Result.Try((int i) => { i++; }, 1);
        
        Assert.True(result.Success);
    }

    [Fact]
    public void TryActionPExceptionError()
    {
        Result result = Result.Try((int i) =>
            {
                i++;
                throw new Exception("ActionP throwing Exception");
            }, 
            1);

        Assert.False(result.Success);
        Assert.NotNull(result.Exception);
        Assert.Equal("ActionP throwing Exception", result.ErrorMessage);
    }

    [Fact]
    public void TryActionP1P2NoExceptionSuccess()
    {
        Result result = Result.Try((int i, string msg) => { _ = $"{i} {msg}"; }, 1, "Hi") ;

        Assert.True(result.Success);
    }

    [Fact]
    public void TryActionP1P2ExceptionError()
    {
        Result result = Result.Try((int i, string msg) => 
            { 
                _ = $"{i} {msg}"; 
                throw new Exception("ActionP1P2 throwing Exception"); 
            }, 
            1, "Hi");

        Assert.False(result.Success);
        Assert.NotNull(result.Exception);
        Assert.Equal("ActionP1P2 throwing Exception", result.ErrorMessage);
    }

    [Fact]
    public void TryFuncNoExceptionSuccess()
    {
        Result result = Result.Try(() => Result.Ok());
        
        Assert.True(result.Success);
    }

    [Fact]
    public void TryFuncNoExceptionError()
    {
        Result result = Result.Try(() => Result.Error("Func returned Error"));

        Assert.False(result.Success);
        Assert.Equal("Func returned Error", result.ErrorMessage);
    }

    [Fact]
    public void TryFuncExceptionError()
    {
        Result result = Result.Try(() => throw new Exception("Func throwing Exception"));

        Assert.False(result.Success);
        Assert.Equal("Func throwing Exception", result.ErrorMessage);
        Assert.NotNull(result.Exception);
    }

    [Fact]
    public void TryFuncBoolNoExceptionSuccess()
    {
        Result result = Result.Try(() => true);

        Assert.True(result.Success);
    }

    [Fact]
    public void TryFuncBoolNoExceptionError()
    {
        Result result = Result.Try(() => false);

        Assert.False(result.Success);
        Assert.True(string.IsNullOrEmpty(result.ErrorMessage));
    }

    [Fact]
    public void TryFuncPNoExceptionSuccess()
    {
        Result result = Result.Try((int i) => 
            {
                i++; 
                return Result.Ok(); 
            }, 
            1);
        
        Assert.True(result.Success);
    }

    [Fact]
    public void TryFuncPNoExceptionError()
    {
        Result result = Result.Try((string msg) => Result.Error(msg), "Passed Error Message");

        Assert.False(result.Success);
        Assert.Null(result.Exception);
        Assert.Equal("Passed Error Message", result.ErrorMessage);
    }

    [Fact]
    public void TryFuncPExceptionError()
    {
        Result result = Result.Try((string msg) => throw new Exception(msg), "Exception Error Message");

        Assert.False(result.Success);
        Assert.NotNull(result.Exception);
        Assert.Equal("Exception Error Message", result.ErrorMessage);
    }

    [Fact]
    public void TryFuncP1P2NoExceptionSuccess()
    {
        Result result = Result.Try((int i, string msg) => 
            { 
                _ = $"{i} {msg}"; 
                return Result.Ok();
            }, 
            1, "Hi");

        Assert.True(result.Success);
    }

    [Fact]
    public void TryFuncP1P2NoExceptionError()
    {
        Result result = Result.Try((int i, string msg) =>
            {
                _ = $"{i} {msg}";
                return Result.Error(msg);
            },
            1, "FuncP1P2 Error Message");

        Assert.False(result.Success);
        Assert.Null(result.Exception);
        Assert.Equal("FuncP1P2 Error Message", result.ErrorMessage);
    }

    [Fact]
    public void TryFuncP1P2ExceptionError()
    {
        Result result = Result.Try((int i, string msg) =>
        {
            _ = $"{i} {msg}";
            throw new Exception("FuncP1P2 throwing Exception");
            return Result.Error(msg);
        },
            1, "Hi");

        Assert.False(result.Success);
        Assert.NotNull(result.Exception);
        Assert.Equal("FuncP1P2 throwing Exception", result.ErrorMessage);
    }

    [Fact]
    public async void TryAsyncFuncNoExceptionSuccess()
    {
        using CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Result result = await Result.TryAsync(async (CancellationToken token) => await Task.Delay(250, token), cts.Token);

        Assert.True(result.Success);
    }

    [Fact]
    public async void TryAsyncFuncExceptionError()
    {
        using CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(250);

        Result result = await Result.TryAsync(async (CancellationToken token) => await Task.Delay(500, token), cts.Token);

        Assert.False(result.Success);
        Assert.NotNull(result.Exception);
        Assert.IsType<TaskCanceledException>(result.Exception);
        Assert.Equal("A task was canceled.", result.ErrorMessage);
    }

    [Fact]
    public async void TryAsyncFuncPNoExceptionSuccess()
    {
        using CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Result result = await Result.TryAsync(async(int i, CancellationToken token) =>
            {
                i++;
                await Task.Delay(250, token);
            },             
            1, cts.Token);

        Assert.True(result.Success);
    }

    [Fact]
    public async void TryAsyncFuncPExceptionError()
    {
        using CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(250);

        Result result = await Result.TryAsync(async (int i, CancellationToken token) =>
        {
            i++;
            await Task.Delay(500, token);
        },
            1, cts.Token);

        Assert.False(result.Success);
        Assert.NotNull(result.Exception);
        Assert.IsType<TaskCanceledException>(result.Exception);
        Assert.Equal("A task was canceled.", result.ErrorMessage);
    }

    [Fact]
    public async void TryAsyncFuncP1P2NoExceptionSuccess()
    {
        using CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Result result = await Result.TryAsync(async (int i, string msg, CancellationToken token) =>
        {
            _ = $"{i} {msg}";
            await Task.Delay(250, token);
        },
            1, "Hi", cts.Token);

        Assert.True(result.Success);
    }

    [Fact]
    public async void TryAsyncFuncP1P2ExceptionError()
    {
        using CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(250);

        Result result = await Result.TryAsync(async (int i, string msg, CancellationToken token) =>
        {
            _ = $"{i} {msg}";
            await Task.Delay(500, token);
        },
            1, "Hi", cts.Token);

        Assert.False(result.Success);
        Assert.NotNull(result.Exception);
        Assert.IsType<TaskCanceledException>(result.Exception);
        Assert.Equal("A task was canceled.", result.ErrorMessage);
    }
}
