/*
 * Student ID :1690704075
 * Name       :Lab02
 * Section    :129D
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */

using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args) //สมโป้ง
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"CurrentHp: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack: {attackPower}");
            Console.WriteLine($"CritPower: {critMultiplier}");
            Console.WriteLine($"Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HpPercent: {hpPercent}%");
            Console.WriteLine($"CurrentHp: {currentHp} / {maxHp}");
            Console.WriteLine();
            Console.WriteLine();
            currentHp = currentHp - 60;
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"CurrentHp: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HpPercent: {hpPercent}%");
        }
    }
}