/*
* Student ID :1690704075
* Name       :Lab05
* Section    :129D
* No.        :N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game Title
            Console.WriteLine("---- Plant vs Zombie ----");
            Console.WriteLine("Plant vs Zombie -- Fight Damage Calculator");

            //Hero stats input
            Console.WriteLine("Plant Health: ");
            bool plantHpOk = int.TryParse(Console.ReadLine(), out int plantHp);
            Console.WriteLine("Plant Atk: ");
            bool plantAtkOk = int.TryParse(Console.ReadLine(), out int plantAtk);
            Console.WriteLine("Plant Def: ");
            bool plantDefOk = int.TryParse(Console.ReadLine(), out int plantDef);

            //Monster stats input
            Console.WriteLine("Zombie Health: ");
            bool zombieHpOk = int.TryParse(Console.ReadLine(), out int zombieHp);
            Console.WriteLine("Zombie Atk: ");
            bool zombieAtkOk = int.TryParse(Console.ReadLine(), out int zombieAtk);
            Console.WriteLine("Zombie Def: ");
            bool zombieDefOk = int.TryParse(Console.ReadLine(), out int zombieDef);

            //Input validation input/output
            bool plantStatValid = plantHpOk && plantAtkOk && plantDefOk;
            bool zombieStatValid = zombieHpOk || zombieAtkOk || zombieDefOk;
            Console.WriteLine($"\nPLANT STAT: {plantStatValid}");
            Console.WriteLine($"ZOMBIE STAT: {zombieStatValid}");

            Console.WriteLine($"[PLANT]    HP: {plantHp} ATK: {plantAtk} DEF: {plantDef}");
            Console.WriteLine($"[ZOMBIE]    HP: {zombieHp} ATK: {zombieAtk} DEF: {zombieDef}");

            //Arithmetic & Compound Assignment ( + )

            int potionHeal = 5;
            plantHp += potionHeal;
            Console.WriteLine($"\nPlant drinks a potion, heals {potionHeal} Hp. Plant Hp: {plantHp}");

            int normalDmg = Math.Max(0, plantAtk - zombieDef);
            Console.WriteLine($"Plant would deals normal attack: {normalDmg}");

            int heavyDmg = Math.Max(0, (plantAtk * 2) - zombieDef);
            Console.WriteLine($"Plant would deals heavy attack: {heavyDmg}");

            //Random Critical Attack
            Random rng = new Random();
            int critRoll = rng.Next(1, 101); //random from 100%
            bool isCrit = critRoll <= 67; //67% chance

            int critDmg = normalDmg + Convert.ToInt32(isCrit) * normalDmg;
            Console.WriteLine($"Crit roll: {critRoll}. Critical Hit: {isCrit}");
            Console.WriteLine($"If critical hit plater would deal {critDmg} DMG!!!!!!!!!");

            
            int critRollHeavy = rng.Next(1, 101); //random from 100%
            bool isCritHeavy = critRollHeavy <= 95; //95% chance
            int critDmgHeavy = heavyDmg + Convert.ToInt32(isCritHeavy) * heavyDmg;
            Console.WriteLine($"Crit roll: {critRollHeavy}. Critical Hit: {isCritHeavy}");
            Console.WriteLine($"If critical hit plater would deal {critDmgHeavy} DMG!!!!!!!!!");


        }
    }
}
