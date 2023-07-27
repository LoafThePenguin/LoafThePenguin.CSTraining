using LoafThePenguin.CSTraining.Basic;
using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Tests.Basic;

public sealed class TrimWhitespacesTests
{
    private readonly TrimWhitespacesAlgorithm _algorithm;
    private readonly TrimWhitespaces _trimWhitespaces;

    public TrimWhitespacesTests()
    {
        _algorithm = new TrimWhitespacesAlgorithm();
        _trimWhitespaces = new TrimWhitespaces();
    }

    [Theory]
    [InlineData("")]
    [InlineData("    ")]
    [InlineData("  DJfsfdj ")]
    [InlineData(" 9300234c")]
    [InlineData(" abc ")]
    [InlineData(" abc     ")]
    [InlineData("sd fsd ff")]
    public void TrimWhitespaces(string str)
    {
        Assert.Equal(_algorithm.Run(str), _trimWhitespaces.Run(str));
    }
}