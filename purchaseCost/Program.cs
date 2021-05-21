using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace purchaseCost
{
    class Program
    {
        static void Main(string[] args)
        {
            int rubles = Convert.ToInt32(Console.ReadLine());
            int penny = Convert.ToInt32(Console.ReadLine());
            int numberPies = Convert.ToInt32(Console.ReadLine());

            int conversionRublesKopecks = (rubles * 100) + penny;
            int purchaseAmount = conversionRublesKopecks * numberPies;
            int balanceKopecks = purchaseAmount % 100;
            int balanceRubles = purchaseAmount / 100;

            Console.WriteLine(balanceRubles + " " + balanceKopecks);
        }
    }
}