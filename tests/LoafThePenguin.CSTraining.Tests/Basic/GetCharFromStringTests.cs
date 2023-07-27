using LoafThePenguin.CSTraining.Basic;
using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Tests.Basic;

public sealed class GetCharFromStringTests
{
    private readonly GetCharFromStringAlgorithm _algorithm;
    private readonly GetCharFromString _getCharFromString;

    public GetCharFromStringTests()
    {
        _algorithm = new GetCharFromStringAlgorithm();
        _getCharFromString = new GetCharFromString();
    }

    [Theory]
    [InlineData("abc", 3)]
    [InlineData("DJfsfdj", 5)]
    [InlineData("9300234c", 3)]
    [InlineData("abc", 0)]
    [InlineData("GFsdgh", 5)]
    public void GetCharFromString(string str, int index)
    {
        Assert.Equal(_algorithm.Run(str, index), _getCharFromString.Run(str, index));
    }
}
