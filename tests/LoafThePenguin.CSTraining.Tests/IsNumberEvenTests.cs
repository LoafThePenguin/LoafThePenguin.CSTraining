using LoafThePenguin.CSTraining.Conditions;
using LoafThePenguin.CSTraining.Core.TrustedAlgorithms.Condition;
using LoafThePenguin.CSTraining.Core.TrustedAlgorithms.Cycles;
using LoafThePenguin.CSTraining.Cycles;

namespace LoafThePenguin.CSTraining.Tests;

public sealed class DigitsSumTests
{
    private readonly DigitsSumAlgorithm _algorithm;
    private readonly DigitsSum _digitsSum;

    public DigitsSumTests()
    {
        _algorithm = new DigitsSumAlgorithm();
        _digitsSum = new DigitsSum();
    }

    [Theory]
    [InlineData(123)]
    [InlineData(464)]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(538723)]
    [InlineData(911231)]
    public void Digits_Sum(int number)
    {
        int expected = _algorithm.Run(number);
        int actual = _digitsSum.Run(number);

        Assert.Equal(expected, actual);
    }
}

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