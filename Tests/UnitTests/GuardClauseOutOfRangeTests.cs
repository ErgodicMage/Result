namespace UnitTests;

public class GuardClauseOutOfRangeTests
{
    [Fact]
    public void RangeSuccessShort()
    {
        short from = 10;
        short to = 20;
        short value = 15;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.True(result.Success);
    }

    [Fact]
    public void RangeInvalidShort()
    {
        short from = 30;
        short to = 20;
        short value = 15;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeErrorLessShort()
    {
        short from = 10;
        short to = 20;
        short value = 5;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeErrorGreaterShort()
    {
        short from = 10;
        short to = 20;
        short value = 25;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeSuccessInt()
    {
        int from = 10;
        int to = 20;
        int value = 15;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.True(result.Success);
    }

    [Fact]
    public void RangeInvalidInt()
    {
        int from = 30;
        int to = 20;
        int value = 15;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeErrorLessInt()
    {
        int from = 10;
        int to = 20;
        int value = 5;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeErrorGreaterInt()
    {
        int from = 10;
        int to = 20;
        int value = 25;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeSuccessLong()
    {
        long from = 10;
        long to = 20;
        long value = 15;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.True(result.Success);
    }

    [Fact]
    public void RangeInvalidLong()
    {
        long from = 30;
        long to = 20;
        long value = 15;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeErrorLessLong()
    {
        long from = 10;
        long to = 20;
        long value = 5;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeErrorGreaterlong()
    {
        long from = 10;
        long to = 20;
        long value = 25;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeSuccessFloat()
    {
        float from = 10;
        float to = 20;
        float value = 15;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.True(result.Success);
    }

    [Fact]
    public void RangeInvalidFloat()
    {
        float from = 30;
        float to = 20;
        float value = 15;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeErrorLessFloat()
    {
        float from = 10;
        float to = 20;
        float value = 5;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeErrorGreaterFloat()
    {
        float from = 10;
        float to = 20;
        float value = 25;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeSuccessDouble()
    {
        double from = 10;
        double to = 20;
        double value = 15;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.True(result.Success);
    }

    [Fact]
    public void RangeInvalidDouble()
    {
        double from = 30;
        double to = 20;
        double value = 15;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeErrorLessDouble()
    {
        double from = 10;
        double to = 20;
        double value = 5;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeErrorGreaterDouble()
    {
        double from = 10;
        double to = 20;
        double value = 25;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeSuccessDecimal()
    {
        decimal from = 10;
        decimal to = 20;
        decimal value = 15;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.True(result.Success);
    }

    [Fact]
    public void RangeInvalidDecimal()
    {
        decimal from = 30;
        decimal to = 20;
        decimal value = 15;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeErrorLessDecimal()
    {
        decimal from = 10;
        decimal to = 20;
        decimal value = 5;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }

    [Fact]
    public void RangeErrorGreaterDecimal()
    {
        decimal from = 10;
        decimal to = 20;
        decimal value = 25;

        Result result = GuardClause.OutOfRange(value, from, to);

        Assert.False(result.Success);
    }
}
