using LoafThePenguin.CSTraining.Core;

namespace LoafThePenguin.CSTraining.Conditions;

/*
 * Определить является ли число чётным.
 */
public sealed class IsNumberEven : IAlgorithm<int, bool>
{
    public bool Run(int input)
    {
        return input % 2 == 0;
    }
}
