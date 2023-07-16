using LoafThePenguin.CSTraining.Core;

namespace LoafThePenguin.CSTraining.Basic;

/*
 * Написать алогритм преобразования числа таким образом, чтобы перевернуть его.
 * Например: 123456 -> 654321.
 */
public sealed class ReverseNumber : IAlgorithm<int, int>
{
    public int Run(int input)
    {
        int reversed = 0;
   
        do
        {
            int num = input % 10;
            reversed = (reversed * 10) + num;
            input = (input - num) / 10;
            
        } while(input>0);
        return reversed;
    }
}
