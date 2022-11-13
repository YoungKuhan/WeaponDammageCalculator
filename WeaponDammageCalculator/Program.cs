using System;

namespace WeaponDammageCalculator
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));

            while (true)
            {
                Console.Write("0 - ani magiczny, ani płonący, 1 - magiczny, 2 - płonący, " +
                    "3 - oba, cokolwiek innego - wyjście: ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;

                Console.Write("\nM - miecz, S strzały, cokolwiek innego - wyjście: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                switch (weaponKey)
                {
                    case 'M':
                        swordDamage.Roll = RollDice(3);
                        swordDamage.Magic = (key == '1' || key == '3');
                        swordDamage.Flaming = (key == '2' || key == '3');
                        Console.WriteLine(
                           $"\nRzut kostką: {swordDamage.Roll} obrażenia: {swordDamage.Damage} HP\n");
                        break;

                    case 'S':
                        arrowDamage.Roll = RollDice(1);
                        arrowDamage.Magic = (key == '1' || key == '3');
                        arrowDamage.Flaming = (key == '2' || key == '3');
                        Console.WriteLine(
                           $"\nRzut kostką: {arrowDamage.Roll} obrażenia: {arrowDamage.Damage} HP\n");
                        break;

                    default:
                        return;
                }
            }
        }

        private static int RollDice(int numberOfRolls)
        {
            int total = 0;
            for (int i = 0; i < numberOfRolls; i++) total += random.Next(1, 7);
            return total;
        }
    }

}
