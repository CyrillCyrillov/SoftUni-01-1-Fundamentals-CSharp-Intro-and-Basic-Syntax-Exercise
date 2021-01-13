using System;

namespace Task10_Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardtPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            
            float cost = ((lostGames / 2) * headsetPrice) +
                         ((lostGames / 3) * mousePrice) +
                         ((lostGames / 6) * keyboardtPrice) +
                         ((lostGames / 12) * displayPrice);

            Console.WriteLine($"Rage expenses: {cost:F2} lv.");
        }
    }
}
