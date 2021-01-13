using System;

namespace Task07_Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            while (true)
            {
                string next = Console.ReadLine();
                if (next == "Start")
                    {
                        break;
                    }
                double nextCoin = double.Parse(next);
                switch (nextCoin)
                    {
                        case 0.1:
                        case 0.2:
                        case 0.5:
                        case 1:
                        case 2:
                                sum += nextCoin;
                                break;
                        default:
                                Console.WriteLine($"Cannot accept {nextCoin}");
                                break;
                    }
            }

            string product = Console.ReadLine();

            while (true)
            {
                double productPrice = 0;
                
                if (product == "End") break;
               
                switch (product)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }

                if (productPrice <= sum)
                    {
                        sum -= productPrice;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
