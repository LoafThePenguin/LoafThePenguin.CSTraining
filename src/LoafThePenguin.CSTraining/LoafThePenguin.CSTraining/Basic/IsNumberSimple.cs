using LoafThePenguin.CSTraining.Core;

namespace LoafThePenguin.CSTraining.Basic;

/*
 * Определить является ли число простым
 */
public sealed class IsNumberSimple : IAlgorithm<int, bool>
{
    public bool Run(int input)
    {
        for (int i = 2; i <= input / 2; i++)
        {
            if (input % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
