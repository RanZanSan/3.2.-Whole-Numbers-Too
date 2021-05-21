using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int lastNumber = n % 10;

            Console.WriteLine(lastNumber);
            Console.ReadKey();
        }
    }
}