using System;

namespace IterationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            do
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i}");
                }
                count++;
            } while (count < 5);
        }
    }
}
