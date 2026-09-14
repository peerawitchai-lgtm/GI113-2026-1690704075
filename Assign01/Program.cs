/*
 * Student ID :1690704075
 * Name       :Assign01
 * Section    :129D
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 * */using System.ComponentModel;
using System.Linq;

namespace Assign01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string gameName = "Plant vs Zombies 2"; //const
            var charName = "Sunflower";
            var charType = "Enlighten-mint";
            var sunProduction = "Normal";
            int charLevel = 1;
            int charRecharge = 5;
            double charHealth = 300.727;
            double charAttack = 0.0;
            float charSunCost = 50.0f;
            bool charIsObtained = true;
            string art = "                                \r\n                                \r\n         ####-####-####.        \r\n        .###.      .###.        \r\n     ###...-#########...###     \r\n  -#....#####-+---+#####-...#+  \r\n ####.###-+############+##.#### \r\n ....##++###..#####..######.... \r\n ###.#######..#####...#####.### \r\n +...########+#####+#######...+ \r\n ####.+##...##########.###.#### \r\n -###..+####.........+##-..###- \r\n    .###.#+############.###.    \r\n     ###.+.......--...+.###     \r\n         ####.####.####         \r\n           .-.####.-.           \r\n          .++-..-.-++.          \r\n           ###+##+###           \r\n          +##-.++-+###          \r\n       -####.####+#..+##-       \r\n           -+##########.        \r\n                                \r\n                                ";
            double charRechargeAsDouble = charRecharge;
            double charHealthTruncated = (int)charHealth;
            double charHealthRounded = Convert.ToInt32(charHealth);


            Console.WriteLine(gameName);
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine($"|             {charName}              |");              
            Console.WriteLine(" ------------------------------------");

            // Print art and stats side-by-side
            var artLines = art.Split('\n').Select(l => l.TrimEnd('\r')).ToArray();
            var infoLines = new[]
            {
                "",
                "",
                $"      Levels: {charLevel}     Type:{charType}",
                "","","",
                $"      Sun Cost = {charSunCost}  Sun Production: {sunProduction}",
                "",
                $"      HP: {charHealth}   HPRounded: {charHealthRounded}   HPTruncated: {charHealthTruncated}",
                "", 
                $"      Recharge: {charRecharge} seconds",
                $"      RechargeAsDouble: {charRechargeAsDouble} seconds",
                "",
                $"      Atk: {charAttack}",
                $"",
                $"      Sunflowers are essential for you to produce extra sun.",
                $"      Try planting as many as you can!",
                "",
                "",
                "",
                $"      Obtained:{charIsObtained}",
            };

            int artWidth = artLines.Max(l => l.Length);
            int totalLines = Math.Max(artLines.Length, infoLines.Length);

            for (int i = 0; i < totalLines; i++)
            {
                string left = i < artLines.Length ? artLines[i] : string.Empty;
                string right = i < infoLines.Length ? infoLines[i] : string.Empty;
                Console.WriteLine(left.PadRight(artWidth + 4) + right);
            }
        }
    }
}
