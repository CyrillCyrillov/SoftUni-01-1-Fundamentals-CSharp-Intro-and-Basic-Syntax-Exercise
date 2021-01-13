using System;

namespace Task09_Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            float amountOfMoney = float.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            float priceOfLightsabers = float.Parse(Console.ReadLine());
            float priceOfRobes = float.Parse(Console.ReadLine());
            float priceOfBelts = float.Parse(Console.ReadLine());

            double neededMoney = (Math.Ceiling(countOfStudents * 1.1) * priceOfLightsabers) +
                                 (countOfStudents * priceOfRobes) +
                                 ((countOfStudents - (countOfStudents / 6)) * priceOfBelts);

            if (amountOfMoney >= neededMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(neededMoney - amountOfMoney):f2}lv more.");
            }
        }
    }
}
