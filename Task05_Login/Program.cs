using System;

namespace Task05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }

            
            int counter = 0;
            while (true)
            {
                string login = Console.ReadLine();
                if (login == password)
                    {
                        Console.WriteLine($"User {userName} logged in.");
                        break;
                    }
                else
                    {
                        counter += 1;
                        if (counter == 4)
                            {
                                Console.WriteLine($"User {userName} blocked!");
                                break;
                            }
                        Console.WriteLine("Incorrect password. Try again.");
                }
                
            }            
        }
    }
}
