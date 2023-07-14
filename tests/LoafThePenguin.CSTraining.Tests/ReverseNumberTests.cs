using LoafThePenguin.CSTraining.Basic;
using LoafThePenguin.CSTraining.Core.Basic.Cycles;

namespace LoafThePenguin.CSTraining.Tests;

public sealed class ReverseNumberTests
{
    private readonly ReverseNumberAlgorithm _reverseNumberAlgorithm;
    private readonly ReverseNumber _reverseNumber;

    public ReverseNumberTests()
    {
        _reverseNumber = new ReverseNumber();
        _reverseNumberAlgorithm = new ReverseNumberAlgorithm();
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(123)]
    [InlineData(10)]
    [InlineData(1000)]
    [InlineData(12340)]
    public void Reverse_Number(int number)
    {
        Assert.Equal(_reverseNumberAlgorithm.Run(number), _reverseNumber.Run(number));
    }
}
