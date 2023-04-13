namespace UnitTests;

public class GuardClauseMinMaxTests
{
    [Fact]
    public void MinimumShortSuccess()
    {
        short min = 10;
        short input = 15;
        Result result = GuardClause.Minimum(input, min);

        Assert.True(result.Success);
    }

    [Fact]
    public void MinimumShortSameSuccess()
    {
        short min = 10;
        short input = 10;
        Result result = GuardClause.Minimum(input, min);

        Assert.True(result.Success);
    }

    [Fact]
    public void MinimumShortError()
    {
        short min = 10;
        short input = 5;
        Result result = GuardClause.Minimum(input, min);

        Assert.False(result.Success);
    }

    [Fact]
    public void MinimumIntSuccess()
    {
        int min = 10;
        int input = 15;
        Result result = GuardClause.Minimum(input, min);

        Assert.True(result.Success);
    }

    [Fact]
    public void MinimumIntSameSuccess()
    {
        int min = 10;
        int input = 10;
        Result result = GuardClause.Minimum(input, min);

        Assert.True(result.Success);
    }

    [Fact]
    public void MinimumIntError()
    {
        int min = 10;
        int input = 5;
        Result result = GuardClause.Minimum(input, min);

        Assert.False(result.Success);
    }

    [Fact]
    public void MinimumLongSuccess()
    {
        long min = 10;
        long input = 15;
        Result result = GuardClause.Minimum(input, min);

        Assert.True(result.Success);
    }

    [Fact]
    public void MinimumLongSameSuccess()
    {
        long min = 10;
        long input = 10;
        Result result = GuardClause.Minimum(input, min);

        Assert.True(result.Success);
    }

    [Fact]
    public void MinimumLongError()
    {
        long min = 10;
        long input = 5;
        Result result = GuardClause.Minimum(input, min);

        Assert.False(result.Success);
    }

    [Fact]
    public void MinimumFloatSuccess()
    {
        float min = 10;
        float input = 15;
        Result result = GuardClause.Minimum(input, min);

        Assert.True(result.Success);
    }

    [Fact]
    public void MinimumFloatSameSuccess()
    {
        float min = 10;
        float input = 10;
        Result result = GuardClause.Minimum(input, min);

        Assert.True(result.Success);
    }

    [Fact]
    public void MinimumFloatError()
    {
        float min = 10;
        float input = 5;
        Result result = GuardClause.Minimum(input, min);

        Assert.False(result.Success);
    }

    [Fact]
    public void MinimumDoubleSuccess()
    {
        double min = 10;
        double input = 15;
        Result result = GuardClause.Minimum(input, min);

        Assert.True(result.Success);
    }

    [Fact]
    public void MinimumDoubleSameSuccess()
    {
        double min = 10;
        double input = 10;
        Result result = GuardClause.Minimum(input, min);

        Assert.True(result.Success);
    }

    [Fact]
    public void MinimumDoubleError()
    {
        double min = 10;
        double input = 5;
        Result result = GuardClause.Minimum(input, min);

        Assert.False(result.Success);
    }

    [Fact]
    public void MinimumDecimalSuccess()
    {
        decimal min = 10;
        decimal input = 15;
        Result result = GuardClause.Minimum(input, min);

        Assert.True(result.Success);
    }

    [Fact]
    public void MinimumDecimalSameSuccess()
    {
        decimal min = 10;
        decimal input = 10;
        Result result = GuardClause.Minimum(input, min);

        Assert.True(result.Success);
    }

    [Fact]
    public void MinimumDecimalError()
    {
        decimal min = 10;
        decimal input = 5;
        Result result = GuardClause.Minimum(input, min);

        Assert.False(result.Success);
    }

    [Fact]
    public void MaximumShortSuccess()
    {
        short max = 10;
        short input = 5;
        Result result = GuardClause.Maximum(input, max);

        Assert.True(result.Success);
    }

    [Fact]
    public void MaximumShortSameSuccess()
    {
        short max = 10;
        short input = 10;
        Result result = GuardClause.Maximum(input, max);

        Assert.True(result.Success);
    }

    [Fact]
    public void MaximumShortError()
    {
        short max = 10;
        short input = 15;
        Result result = GuardClause.Maximum(input, max);

        Assert.False(result.Success);
    }

    [Fact]
    public void MaximumIntSuccess()
    {
        int max = 10;
        int input = 5;
        Result result = GuardClause.Maximum(input, max);

        Assert.True(result.Success);
    }

    [Fact]
    public void MaximumIntSameSuccess()
    {
        int max = 10;
        int input = 10;
        Result result = GuardClause.Maximum(input, max);

        Assert.True(result.Success);
    }

    [Fact]
    public void MaximumIntError()
    {
        int max = 10;
        int input = 15;
        Result result = GuardClause.Maximum(input, max);

        Assert.False(result.Success);
    }

    [Fact]
    public void MaximumLongSuccess()
    {
        long max = 10;
        long input = 5;
        Result result = GuardClause.Maximum(input, max);

        Assert.True(result.Success);
    }

    [Fact]
    public void MaximumLongSameSuccess()
    {
        long max = 10;
        long input = 10;
        Result result = GuardClause.Maximum(input, max);

        Assert.True(result.Success);
    }

    [Fact]
    public void MaximumLongError()
    {
        long max = 10;
        long input = 15;
        Result result = GuardClause.Maximum(input, max);

        Assert.False(result.Success);
    }

    [Fact]
    public void MaximumFloatSuccess()
    {
        float max = 10;
        float input = 5;
        Result result = GuardClause.Maximum(input, max);

        Assert.True(result.Success);
    }

    [Fact]
    public void MaximumFloatSameSuccess()
    {
        float max = 10;
        float input = 10;
        Result result = GuardClause.Maximum(input, max);

        Assert.True(result.Success);
    }

    [Fact]
    public void MaximumFloatError()
    {
        float max = 10;
        float input = 15;
        Result result = GuardClause.Maximum(input, max);

        Assert.False(result.Success);
    }

    [Fact]
    public void MaximumDoubleSuccess()
    {
        double max = 10;
        double input = 5;
        Result result = GuardClause.Maximum(input, max);

        Assert.True(result.Success);
    }

    [Fact]
    public void MaximumDoubleSameSuccess()
    {
        double max = 10;
        double input = 10;
        Result result = GuardClause.Maximum(input, max);

        Assert.True(result.Success);
    }

    [Fact]
    public void MaximumDoubleError()
    {
        double max = 10;
        double input = 15;
        Result result = GuardClause.Maximum(input, max);

        Assert.False(result.Success);
    }

    [Fact]
    public void MaximumDecimalSuccess()
    {
        decimal max = 10;
        decimal input = 5;
        Result result = GuardClause.Maximum(input, max);

        Assert.True(result.Success);
    }

    [Fact]
    public void MaximumDecimalSameSuccess()
    {
        decimal max = 10;
        decimal input = 10;
        Result result = GuardClause.Maximum(input, max);

        Assert.True(result.Success);
    }

    [Fact]
    public void MaximumDecimalError()
    {
        decimal max = 10;
        decimal input = 15;
        Result result = GuardClause.Maximum(input, max);

        Assert.False(result.Success);
    }
}
