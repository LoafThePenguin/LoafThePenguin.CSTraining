using LoafThePenguin.CSTraining.Basic;
using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Tests.Basic;

public sealed class GetCharByIndexFromStringTests
{
    private readonly GetCharFromStringByIndexAlgorithm _algorithm;
    private readonly GetCharByIndexFromString _getCharFromString;

    public GetCharByIndexFromStringTests()
    {
        _algorithm = new GetCharFromStringByIndexAlgorithm();
        _getCharFromString = new GetCharByIndexFromString();
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
