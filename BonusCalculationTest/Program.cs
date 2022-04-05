using System;

namespace BonusCalculationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange Nettoresultat: ");
            double nettoResultat = int.Parse(Console.ReadLine());
            double bonusPott = nettoResultat * 0.05;

            Console.Write("Ange Totalt antal debiterade konsult timmar: ");
            double debiteradeTimmarTotalt = int.Parse(Console.ReadLine());

            Console.Write("Ange antal år i firman: ");
            double NumberOfYears = int.Parse(Console.ReadLine());

            Console.Write("Antal bebiterade timmar: ");
            double debiteradeTimmar = int.Parse(Console.ReadLine());

            double bonusPottProcent = debiteradeTimmar / debiteradeTimmarTotalt;
            double bonusPottKr = bonusPott * (debiteradeTimmar / debiteradeTimmarTotalt);

            Console.WriteLine($"Andel av bonus i %: {bonusPottProcent}%");
            Console.WriteLine($"Bonus i kr {bonusPottKr}");
        }
    }
}
