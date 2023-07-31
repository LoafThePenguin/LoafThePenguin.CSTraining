using LoafThePenguin.CSTraining.Core;

namespace LoafThePenguin.CSTraining.Basic;

/*
 * Найти букву в строке по индексу.
 */
public sealed class GetCharByIndexFromString : IAlgorithm<string, int, char?>
{
    public char? Run(string str, int index)
    {
        if(str.Length <= index)
        {
            return null;
        }
        char n = str[index];
        return n;
      
    }
}
