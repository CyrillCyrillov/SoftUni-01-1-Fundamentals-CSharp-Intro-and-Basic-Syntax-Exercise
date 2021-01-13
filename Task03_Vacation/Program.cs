using System;

namespace Task03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double sum = 0;

            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                        {
                            sum = numberOfPeople * 8.45;
                        }
                    else if (day == "Saturday")
                        {
                            sum = numberOfPeople * 9.80;
                        }
                    else if (day == "Sunday")
                        {
                            sum = numberOfPeople * 10.46;
                        }
                    if (numberOfPeople >= 30)
                        {
                            sum = sum * 0.85;
                        }
                break;
                                
                case "Business":
                    if (numberOfPeople >= 100)
                        {
                            numberOfPeople = numberOfPeople - 10;
                        }
                    if (day == "Friday")
                        {
                            sum = numberOfPeople * 10.9;
                        }
                    else if (day == "Saturday")
                        {
                            sum = numberOfPeople * 15.6;
                        }
                    else if (day == "Sunday")
                        {
                            sum = numberOfPeople * 16;
                        }
                break;

                case "Regular":
                    if (day == "Friday")
                        {
                            sum = numberOfPeople * 15;
                        }
                    else if (day == "Saturday")
                        {
                            sum = numberOfPeople * 20;
                        }
                    else if (day == "Sunday")
                        {
                            sum = numberOfPeople * 22.5;
                        }
                    if (numberOfPeople >= 10 && numberOfPeople <= 20)
                        {
                        sum = sum * 0.95;
                        }
                break;
            }

            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
