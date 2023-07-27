using LoafThePenguin.CSTraining.Core;

namespace LoafThePenguin.CSTraining.CodeWars;

/*
 * Написать алгоритм, который возвращает сообщение "Hello boss",
 * если name и owner содержат одно и тоже имя (Регистр чувствителен).
 * А если не равны, то возвращает "Hello guest".
 */
public class PersonalizedMessage : IAlgorithm<string, string, string>
{
    public string Run(string name, string owner)
    {
        if (name == owner)
        {
            return "Hello boss";
        }
        return "Hello guest";
    }
}
