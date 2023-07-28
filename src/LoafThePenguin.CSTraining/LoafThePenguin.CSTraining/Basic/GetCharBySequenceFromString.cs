using LoafThePenguin.CSTraining.Core;

namespace LoafThePenguin.CSTraining.Basic;

/*
 * Найти букву в строке по порядковому номеру.
 */
public sealed class GetCharBySequenceFromString : IAlgorithm<string, int, char?>
{
    public char? Run(string str, int seqNum)
    {
        if (str.Length < seqNum)
        {
            return null;
        }

        // Писать код тут.
        throw new NotImplementedException();
    }
}
