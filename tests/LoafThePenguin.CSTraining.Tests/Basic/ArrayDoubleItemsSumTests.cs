using LoafThePenguin.CSTraining.Basic;
using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Tests.Basic;

public sealed class ArrayDoubleItemsSumTests
{
    private readonly ArrayDoubleItemsSum _arrayDoubleItemsSum;
    private readonly ArrayDoubleItemsSumAlgorithm _algorithm;

    public ArrayDoubleItemsSumTests()
    {
        _algorithm = new ArrayDoubleItemsSumAlgorithm();
        _arrayDoubleItemsSum = new ArrayDoubleItemsSum();
    }

    [Theory]
    [InlineData(new[] { 23, 12.23, 93, 1203.23 })]
    [InlineData(new double[] { })]
    [InlineData(new[] { -23.23 })]
    [InlineData(new[] { -23.23, 10, 15.254 })]
    public void Array_Double_Items_Sum(double[] items)
    {
        Assert.Equal(_algorithm.Run(items), _arrayDoubleItemsSum.Run(items));
    }
}
