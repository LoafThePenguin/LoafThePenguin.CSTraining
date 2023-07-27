using LoafThePenguin.CSTraining.Basic;
using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Tests.Basic;

public sealed class GetFirstCharFromStringTests
{
    private readonly GetFirstCharFromStringAlgorithm _algorithm;
    private readonly GetFirstCharFromString _getFirstCharFromString;

    public GetFirstCharFromStringTests()
    {
        _algorithm = new GetFirstCharFromStringAlgorithm();
        _getFirstCharFromString = new GetFirstCharFromString();
    }

    [Theory]
    [InlineData("DJfsfdj")]
    [InlineData("9300234c")]
    [InlineData("abc")]
    public void GetFirstCharFromString(string str)
    {
        Assert.Equal(_algorithm.Run(str), _getFirstCharFromString.Run(str));
    }
}
