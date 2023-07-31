using LoafThePenguin.CSTraining.Core;

namespace LoafThePenguin.CSTraining.Basic;

public sealed class TrimWhitespaces : IAlgorithm<string, string>
{
    public string Run(string input)
    {
        string n = input.Trim();
        return n;
    }
} //удалить пробелы в начале и в конце Trim— удаляет начальные и конечные пробелы из строки