using LoafThePenguin.CSTraining.Core;

namespace LoafThePenguin.CSTraining.Basic;

/*
 * Реализовать регистронезависимое сравнение двух строк.
 * Например: "AbC" будет равно "abc", но не равно "abcd"
 */
public sealed class InsensitiveStringsEquality : IAlgorithm<string, string, bool>
{
    public bool Run(string input1, string input2)
    {
        int comparsion = string.Compare(input1, input2, ignoreCase: true);
        return comparsion == 0;
    }
}
