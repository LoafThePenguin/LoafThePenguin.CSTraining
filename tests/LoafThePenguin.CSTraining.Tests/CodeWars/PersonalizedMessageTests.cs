using LoafThePenguin.CSTraining.CodeWars;
using LoafThePenguin.CSTraining.Core.Tasks.CodeWars;

namespace LoafThePenguin.CSTraining.Tests.CodeWars;

public sealed class PersonalizedMessageTests
{
    private readonly PersonalizedMessage _personalizedMessage;
    private readonly PersonalizedMessageAlgorithm _algorithm;

    public PersonalizedMessageTests()
    {
        _algorithm = new PersonalizedMessageAlgorithm();
        _personalizedMessage = new PersonalizedMessage();
    }

    [Theory]
    [InlineData("Katya", "Misha")]
    [InlineData("", "Misha")]
    [InlineData("Katya", "")]
    [InlineData("Misha", "Misha")]
    public void Personalized_Message(string name, string owner)
    {
        Assert.Equal(_algorithm.Run(name, owner), _personalizedMessage.Run(name, owner));
    }
}
