using System;

namespace Task04_Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endtNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startNumber; i <= endtNumber; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
