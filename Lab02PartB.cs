/*
 * Student ID :1690704075
 * Name       :Lab02PartB
 * Section    :129D
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */

using static System.Net.Mime.MediaTypeNames;

namespace Lab02PartB
{
    internal class Program
    {
        static void Main(string[] args) //สมโป้ง
        {
            string charName1 = "Somchai";
            string charName2 = "Pong";
            string charName3 = "Kai";
            string charName4 = "Potential Girl";
            string charName5 = "Silver Wolf";
            char tierS = 'S';
            char tierA = 'A';
            char tierB = 'B';
            int level = 7;
            int maxHp = 100;
            int currentHp = 100;
            int speed = 12;
            float attackPower = 12.5f;
            float critChance = 17.5f;
            double critMultiplier = 1.45;
            bool isAlive = true;
            bool isnotAlive = false;
            

            Console.WriteLine("===== CHARACTER STATUS: INITIAL =====");
            Console.WriteLine($"Name: {charName1}");
            Console.WriteLine($"Tier: {tierS}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"CurrentHp: {currentHp} / {maxHp}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Attack: {attackPower}");
            Console.WriteLine($"CritChance: {critChance}%");
            Console.WriteLine($"CritPower: {critMultiplier}");
            Console.WriteLine($"Alive: {isAlive}");

            Console.WriteLine();
            attackPower = attackPower + 5;
            critChance = critChance + 5;
            level  = level + 3;
            speed = speed + 3;
            Console.WriteLine($"Name: {charName2}");
            Console.WriteLine($"Tier: {tierS}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"CurrentHp: {currentHp} / {maxHp}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Attack: {attackPower}");
            Console.WriteLine($"CritChance: {critChance}%");
            Console.WriteLine($"CritPower: {critMultiplier}");
            Console.WriteLine($"Alive: {isAlive}");

                        Console.WriteLine();
            attackPower = attackPower - 7.5f;
            level  = level + 1;
            maxHp = maxHp + 100;
            currentHp = currentHp + 100;
            Console.WriteLine($"Name: {charName3}");
            Console.WriteLine($"Tier: {tierA}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"CurrentHp: {currentHp} / {maxHp}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Attack: {attackPower}");
            Console.WriteLine($"CritChance: {critChance}%");
            Console.WriteLine($"CritPower: {critMultiplier}");
            Console.WriteLine($"Alive: {isAlive}");

                        Console.WriteLine();
            attackPower = attackPower - 7;
            critChance = critChance - 5;
            level  = level - 1;
            speed = speed - 4;
            maxHp = maxHp - 50;
            currentHp = currentHp - 50;
            critMultiplier = critMultiplier + 8.55f;
            Console.WriteLine($"Name: {charName4}");
            Console.WriteLine($"Tier: {tierB}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"CurrentHp: {currentHp} / {maxHp}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Attack: {attackPower}");
            Console.WriteLine($"CritChance: {critChance}%");
            Console.WriteLine($"CritPower: {critMultiplier}");
            Console.WriteLine($"Alive: {isnotAlive}");

                        Console.WriteLine();
            attackPower = 999;
            critChance = 100;
            critMultiplier = 999;
            level  = 999;
            maxHp = 9999;
            currentHp = 9999;
            speed = 999;

            char tierX = 'X';
            Console.WriteLine($"Name: {charName5}");
            Console.WriteLine($"Tier: {tierX}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"CurrentHp: {currentHp} / {maxHp}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Attack: {attackPower}");
            Console.WriteLine($"CritChance: {critChance}%");
            Console.WriteLine($"CritPower: {critMultiplier}");
            Console.WriteLine($"Alive: {isAlive}");

        }
    }
}