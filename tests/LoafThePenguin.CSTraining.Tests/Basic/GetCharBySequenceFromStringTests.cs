using LoafThePenguin.CSTraining.Basic;
using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Tests.Basic;

public sealed class GetCharBySequenceFromStringTests
{
    private readonly GetCharFromStringBySequenceAlgorithm _algorithm;
    private readonly GetCharBySequenceFromString _getCharFromString;

    public GetCharBySequenceFromStringTests()
    {
        _algorithm = new GetCharFromStringBySequenceAlgorithm();
        _getCharFromString = new GetCharBySequenceFromString();
    }

    [Theory]
    [InlineData("abc", 3)]
    [InlineData("DJfsfdj", 5)]
    [InlineData("9300234c", 3)]
    [InlineData("GFsdgh", 5)]
    [InlineData("GFsdgh", 6)]
    [InlineData("GFsdgh", 8)]
    public void GetCharFromString(string str, int index)
    {
        Assert.Equal(_algorithm.Run(str, index), _getCharFromString.Run(str, index));
    }
}
