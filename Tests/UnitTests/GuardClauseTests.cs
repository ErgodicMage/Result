using NuGet.Frameworks;

namespace UnitTests;

public class GuardClauseTests
{
    private readonly string goodString = "Good string";
    private readonly string? nullString = default;

    [Fact]
    public void ChainGuardClauses()
    {
        Result result = GuardClause.NullOrEmpty(goodString).Null(nullString).NullOrWhiteSpace(goodString);

        Assert.False(result.Success);
    }
}
