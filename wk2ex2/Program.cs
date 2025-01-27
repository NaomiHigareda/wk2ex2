using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk2ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter an integer
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());
            int sum = SumOfDigits(number);

            //prompt user to enter the sum of the of
            Console.WriteLine($"The sum of the digits {number} is {sum}");
        }
        static int SumOfDigits(int number)
        {   
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
