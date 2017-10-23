using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int result1;
            int result2;

            Console.WriteLine("Enter first number -");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter second number -");
            num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter third number -");
            num3 = Convert.ToInt16(Console.ReadLine());

            result1 = ((num1 + num2) * num3);

            result2 = ((num1 * num2) + (num2 * num3));


            Console.WriteLine("Result of specified numbers " + num1 + "," + num2 + "," + num3 + "," + "(x+y)*z is " + result1 + " and " + " x*y+y*z is " + result2);
            Console.ReadLine();
        }
    }
}
