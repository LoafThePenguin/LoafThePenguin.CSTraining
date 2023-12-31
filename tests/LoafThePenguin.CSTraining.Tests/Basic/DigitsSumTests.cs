using LoafThePenguin.CSTraining.Basic;
using LoafThePenguin.CSTraining.Core.Basic.Cycles;

namespace LoafThePenguin.CSTraining.Tests.Basic;

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
    [InlineData(-23231)]
    public void Digits_Sum(int number)
    {
        int expected = _algorithm.Run(number);
        int actual = _digitsSum.Run(number);

        Assert.Equal(expected, actual);
    }
}
