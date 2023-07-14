using LoafThePenguin.CSTraining.Basic;
using LoafThePenguin.CSTraining.Core.Basic.Condition;

namespace LoafThePenguin.CSTraining.Tests;

public sealed class IsNumberEvenTests
{
    private readonly IsNumberEvenAlgorithm _isNumberEvenAlgorithm;
    private readonly IsNumberEven _isNumberEven;

    public IsNumberEvenTests()
    {
        _isNumberEvenAlgorithm = new IsNumberEvenAlgorithm();
        _isNumberEven = new IsNumberEven();
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(42)]
    [InlineData(5)]
    [InlineData(3)]
    [InlineData(91)]
    public void Is_Number_Even(int number)
    {
        bool expected = _isNumberEvenAlgorithm.Run(number);
        bool actual = _isNumberEven.Run(number);

        Assert.Equal(expected, actual);
    }
}