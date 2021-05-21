using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberTensNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int firstNumbers = n / 10;
            int tensNumber = firstNumbers % 10;

            Console.WriteLine(tensNumber);
            Console.ReadKey();
        }
    }
}