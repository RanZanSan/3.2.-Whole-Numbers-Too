using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invertedNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int firstNumber = number / 100;
            int secondNumber = (number % 100) / 10;
            int thirdNumber = number % 10;
            string sumNumbers = thirdNumber + "" + secondNumber + "" + firstNumber;

            Console.WriteLine(sumNumbers);
            Console.ReadKey();
        }
    }
}