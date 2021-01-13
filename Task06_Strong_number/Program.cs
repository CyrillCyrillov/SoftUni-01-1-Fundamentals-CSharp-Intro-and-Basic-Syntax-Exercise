using System;

namespace Task06_Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int partOfNumber = number;
            
            while (true)
            {
                int nextDigit = partOfNumber % 10;
                int nextDigitFactorial = 1;
                for (int i = 1; i <= nextDigit; i++)
                    {
                        nextDigitFactorial = nextDigitFactorial * i;
                    }
                sum = sum + nextDigitFactorial;
                partOfNumber = partOfNumber / 10;
                if (partOfNumber == 0) break;
            }
            
            if (sum == number)
                {
                    Console.WriteLine("yes");
                }
            else
                {
                    Console.WriteLine("no");
                }            
        }
    }
}
