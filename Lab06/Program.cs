/*
 * Student ID :1690704075
 * Name       :Lab06
 * Section    :129D
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
using System.Collections;
using System.Runtime.CompilerServices;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adventure of Somchai");
            Console.WriteLine(">==== Monster Number 1 ====<");
            Console.WriteLine();
            Console.WriteLine("Choose your move.");
            Console.WriteLine($"Attack: 1 ");
            Console.WriteLine($"Item: 2 ");
            Console.WriteLine($"Special: 3 ");

            double monsterHP = 100.00;
            int playerStamina = 20;
            
            bool inputChoice = int.TryParse(Console.ReadLine(), out int choice);
            if (!inputChoice || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice");
            }
            else if (choice == 1)
            {
                Console.WriteLine("Choose your action");
                Console.WriteLine($"Normal Attack: 1 " + "Heavy Attack: 2 ");
                bool inputAttack = int.TryParse(Console.ReadLine(), out int attack);


                int normalAttack = 20;
                if (!inputAttack || attack < 1 || attack > 2)
                {
                    Console.WriteLine("Invalid choice");
                }
                else if (attack == 1)
                {
                    Console.WriteLine("You choose: Normal Attack");
                    Console.WriteLine($"You hit the monster for: {normalAttack}. Monster HP is now {monsterHP - normalAttack}.");
                }
                else if (attack == 2 && playerStamina >= 10)
                {
                    Console.WriteLine("You choose: Heavy Attack");
                    Console.WriteLine($"You hit the monster for: {normalAttack + 10}. Monster HP is now {monsterHP - (normalAttack + 10)}.");
                    int playerStaminaAfter = playerStamina - 10;
                    Console.WriteLine($"Stamina:{ playerStaminaAfter}");
                    return;
                }
                


            }
            else if (choice == 2)
            {
                Console.WriteLine("Item");
                Console.WriteLine("You don't have any item T-T");
                return;
            }
                

            else
            {
                Console.WriteLine("Special");
            }
            Console.WriteLine("Choose your action");
            Console.WriteLine($"Run: 1 " + "Shield up: 2 ");
            bool inputSpecial = int.TryParse(Console.ReadLine(), out int special);
            if (!inputSpecial || special < 1 || special > 2)
            {
                Console.WriteLine("Invalid choice");
            }

            else if (special == 1)
            {
                Console.WriteLine("You choose: Run");
            }
            else if (special == 2 && playerStamina >= 5)
            {
                Console.WriteLine("You choose: Shield up");
                Console.WriteLine("50% damage reduction");
                return;
            }




        }
    }
}
