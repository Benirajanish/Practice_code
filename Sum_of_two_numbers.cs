using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=0;
            int num2=0;
            int sum1=0;

            Console.WriteLine("Enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum1 = (num1 + num2);

            Console.WriteLine("sum1 of two numbers :" + sum1);
            Console.ReadLine();
        }
    }
}
