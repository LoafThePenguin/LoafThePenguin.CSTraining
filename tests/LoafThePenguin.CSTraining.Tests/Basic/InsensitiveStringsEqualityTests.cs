using LoafThePenguin.CSTraining.Basic;
using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Tests.Basic;

public sealed class InsensitiveStringsEqualityTests
{
    private readonly InsensitiveStringsEqualityAlgorithm _algorithm;
    private readonly InsensitiveStringsEquality _insensitiveStringsEquality;

    public InsensitiveStringsEqualityTests()
    {
        _algorithm = new InsensitiveStringsEqualityAlgorithm();
        _insensitiveStringsEquality = new InsensitiveStringsEquality();
    }

    [Theory]
    [InlineData("", "")]
    [InlineData("abc", "")]
    [InlineData("", "abc")]
    [InlineData(" abC", "abc")]
    [InlineData("abC", "abc")]
    [InlineData("abC", "abc ")]
    [InlineData("QwERtY", "qWeRtY")]
    public void InsensitiveStringsEquality(string str1, string str2)
    {
        Assert.Equal(_algorithm.Run(str1, str2), _insensitiveStringsEquality.Run(str1, str2));
    }
}