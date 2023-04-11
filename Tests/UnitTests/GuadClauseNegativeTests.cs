namespace UnitTests;

public class GuadClauseNegativeTests
{
    [Fact]
    public void NegativeShortSuccess()
    {
        short i = 1;
        Result result = GuardClause.Negative(i);
        Assert.True(result.Success);
    }

    [Fact]
    public void NegativeShortError()
    {
        short i = -1;
        Result result = GuardClause.Negative(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeOrZeroShortSuccess()
    {
        short i = 1;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.True(result.Success);
    }

    [Fact]
    public void NegativeOrZeroShortError()
    {
        short i = -1;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeOrZeroShortErrorZero()
    {
        short i = 0;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeIntSuccess()
    {
        int i = 1;
        Result result = GuardClause.Negative(i);
        Assert.True(result.Success);
    }

    [Fact]
    public void NegativeIntError()
    {
        int i = -1;
        Result result = GuardClause.Negative(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeOrZeroIntSuccess()
    {
        int i = 1;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.True(result.Success);
    }

    [Fact]
    public void NegativeOrZeroIntError()
    {
        int i = -1;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeOrZeroIntErrorZero()
    {
        long i = 0;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeLongSuccess()
    {
        long i = 1;
        Result result = GuardClause.Negative(i);
        Assert.True(result.Success);
    }

    [Fact]
    public void NegativeLongError()
    {
        long i = -1;
        Result result = GuardClause.Negative(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeOrZeroLongSuccess()
    {
        long i = 1;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.True(result.Success);
    }

    [Fact]
    public void NegativeOrZeroLongError()
    {
        long i = -1;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeOrZeroLongErrorZero()
    {
        long i = 0;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeFloatSuccess()
    {
        float i = 1;
        Result result = GuardClause.Negative(i);
        Assert.True(result.Success);
    }

    [Fact]
    public void NegativeFloatError()
    {
        float i = -1;
        Result result = GuardClause.Negative(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeOrZeroFloatSuccess()
    {
        float i = 1;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.True(result.Success);
    }

    [Fact]
    public void NegativeOrZeroFloatError()
    {
        float i = -1;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeOrZeroFloatErrorZero()
    {
        float i = 0;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeDoubleSuccess()
    {
        double i = 1;
        Result result = GuardClause.Negative(i);
        Assert.True(result.Success);
    }

    [Fact]
    public void NegativeDoubleError()
    {
        double i = -1;
        Result result = GuardClause.Negative(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeOrZeroDoubleSuccess()
    {
        double i = 1;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.True(result.Success);
    }

    [Fact]
    public void NegativeOrDoubleDoubleError()
    {
        double i = -1;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeOrZeroDoubleErrorZero()
    {
        double i = 0;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeDecimalSuccess()
    {
        decimal i = 1;
        Result result = GuardClause.Negative(i);
        Assert.True(result.Success);
    }

    [Fact]
    public void NegativeDecimalError()
    {
        decimal i = -1;
        Result result = GuardClause.Negative(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeOrZeroDecimalSuccess()
    {
        decimal i = 1;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.True(result.Success);
    }

    [Fact]
    public void NegativeOrZeroDecimalError()
    {
        decimal i = -1;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.False(result.Success);
    }

    [Fact]
    public void NegativeOrZeroDecimalErrorZero()
    {
        decimal i = 0;
        Result result = GuardClause.NegativeOrZero(i);
        Assert.False(result.Success);
    }

}
