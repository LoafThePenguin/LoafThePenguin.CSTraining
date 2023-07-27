using LoafThePenguin.CSTraining.Core;

namespace LoafThePenguin.CSTraining.Basic;

/*
 * Получить первую букву строки.
 */
public sealed class GetFirstCharFromString : IAlgorithm<string, char?>
{
    public char? Run(string input)
    {
        if(input.Length == 0)
        {
            return null;
        }
        char n = input[0];
        return n;
    }
}
