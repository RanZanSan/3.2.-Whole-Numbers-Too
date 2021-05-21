using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 432;
            int y = x / 100;
            x = (x % 100) * 10;
            x = x + y;

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}