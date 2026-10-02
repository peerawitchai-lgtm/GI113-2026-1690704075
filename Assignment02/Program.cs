/*
 * Student ID :1690704075
 * Name       :
 * Section    :129D
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double SmeltRate = 25.00;
            const double SalvageRate = 50.00;
            const double MaxBatch = 100.00;
            const string IronOre = "Iron Ore";

            Console.WriteLine("$:(S) Smelt");
            Console.WriteLine("$:(B) Salvage");
            char.TryParse(Console.ReadLine(), out char command);
            
            if (command == 'S' || command == 's')
            {
                Console.WriteLine("Enter the amount of iron to smelt (Ore):");
                double.TryParse(Console.ReadLine(), out double amountOfIron);
                if (amountOfIron <= 0)
                {
                    Console.WriteLine("Amount must be greater than zero.");
                }
                else if (amountOfIron > MaxBatch)
                {
                    Console.WriteLine($"Cannot smelt more than {MaxBatch} ore in one operation. Smelting canceled.");
                }
                else
                {
                    double ironIngot = (amountOfIron * SmeltRate) / 100;
                    Console.WriteLine($"The amount of iron smelted is: {ironIngot} Ingots");
                }
            }
            else if (command == 'B' || command == 'b')
            {
                Console.WriteLine("Enter the amount of iron to salvage (Ingots):");
                double.TryParse(Console.ReadLine(), out double amountOfIron);
                if (amountOfIron <= 0)
                {
                    Console.WriteLine("Amount must be greater than zero.");
                }
                else if (amountOfIron > MaxBatch)
                {
                    Console.WriteLine($"Cannot smelt more than {MaxBatch} ore in one operation. Smelting canceled.");
                }
                else
                {
                    double ironOre = (amountOfIron / SalvageRate) * 100;
                    Console.WriteLine($"The amount of iron smelted is: {ironOre} Ores");
                }
            }
            else
            {
                Console.WriteLine("Invalid command");
            }
            int.TryParse(Console.ReadLine(), out int test);



            }
        }
    }

