using LoafThePenguin.CSTraining.Core;

namespace LoafThePenguin.CSTraining.Basic;

/*
 * Написать алгоритм, который вычислит сумму всех цифр числа.
 */
public sealed class DigitsSum : IAlgorithm<int, int>
{
    public int Run(int input)
    {

        int sum = 0; 
        if (input < 0)
        {
            input *= -1; 
        }
        do
        {
            int num = input % 10;
            input = (input - num) / 10;
            sum += num;
        } while (input > 0);
        return sum;
    }
}
