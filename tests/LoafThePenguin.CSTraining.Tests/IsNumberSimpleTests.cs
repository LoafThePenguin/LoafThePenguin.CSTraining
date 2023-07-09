using LoafThePenguin.CSTraining.Conditions;
using LoafThePenguin.CSTraining.Core.Cycles;

namespace LoafThePenguin.CSTraining.Tests;

public sealed class IsNumberSimpleTests
{
    private readonly IsNumberSimpleAlgorithm _isNumberSimpleAlgorithm;
    private readonly IsNumberEven _isNumberEven;

    public IsNumberSimpleTests()
    {
        _isNumberSimpleAlgorithm = new IsNumberSimpleAlgorithm();
        _isNumberEven = new IsNumberEven();
    }

    [Theory]
    [MemberData(nameof(GetNumbers))]
    public void Is_Number_Simple(int number)
    {
        bool expected = _isNumberSimpleAlgorithm.Run(number);
        bool actual = _isNumberEven.Run(number);

        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> GetNumbers()
    {
        return Enumerable.Range(1, 200)
            .Select(x => new object[] { x });
    }
}
