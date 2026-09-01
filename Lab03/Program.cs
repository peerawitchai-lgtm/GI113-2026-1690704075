/*
 * Student ID :1690704075
 * Name       :Lab03
 * Section    :129D
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args) //สมโป้ง
        {
            var bossName = "Kirin";
            var rank = 'S';
            int level = 7;
            int maxLevel = 10;
            int maxHp = 240;
            int currentHp = 115;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;


            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}/{maxLevel}");
            Console.WriteLine($"CurrentHp: {currentHp}/{maxHp}");
            Console.WriteLine($"Attack: {attackPower}");
            Console.WriteLine($"CritPower: {critMultiplier}");
            Console.WriteLine($"Boss: {isBoss}");
            Console.WriteLine();    

            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; //implicit int to double 
            Console.WriteLine($"HP(double): {currentHpDouble}");
            Console.WriteLine();

            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HpPercent(exact): {hpPercentExact}%");
            Console.WriteLine();

            Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");
            Console.WriteLine();

            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (int convert): {critConvert}");
        }
    }
}
