using LoafThePenguin.CSTraining.Core.Cycles;
using LoafThePenguin.CSTraining.Cycles;

namespace LoafThePenguin.CSTraining.Tests;

public sealed class IsNumberSimpleTests
{
    private readonly IsNumberSimpleAlgorithm _isNumberSimpleAlgorithm;
    private readonly IsNumberSimple _isNumberSimple;

    public IsNumberSimpleTests()
    {
        _isNumberSimpleAlgorithm = new IsNumberSimpleAlgorithm();
        _isNumberSimple = new IsNumberSimple();
    }

    [Theory]
    [MemberData(nameof(GetNumbers))]
    public void Is_Number_Simple(int number)
    {
        bool expected = _isNumberSimpleAlgorithm.Run(number);
        bool actual = _isNumberSimple.Run(number);

        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> GetNumbers()
    {
        return Enumerable.Range(1, 200)
            .Select(x => new object[] { x });
    }
}
