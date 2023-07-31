using LoafThePenguin.CSTraining.Core;

namespace LoafThePenguin.CSTraining.Basic;

/*
 * Найти букву в строке по порядковому номеру.123456789 и так далее
 */
public sealed class GetCharBySequenceFromString : IAlgorithm<string, int, char?>
{
    public char? Run(string str, int seqNum)
    {
        if (str.Length < seqNum)
        {
            return null;
        }
        int index= seqNum - 1;
        char n = str[index];
        return n;
    }
}
