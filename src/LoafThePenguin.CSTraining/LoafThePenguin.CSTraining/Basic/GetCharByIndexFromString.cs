using LoafThePenguin.CSTraining.Core;

namespace LoafThePenguin.CSTraining.Basic;

/*
 * Найти букву в строке по индексу.
 */
public sealed class GetCharByIndexFromString : IAlgorithm<string, int, char?>
{
    public char? Run(string input1, int input2)
    {
        if(input1.Length < input2)
        {
            return null;
        }

        // Писать код тут.
        throw new NotImplementedException();
    }
}
