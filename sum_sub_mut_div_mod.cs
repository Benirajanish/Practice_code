using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int sum1 = 0;
            int sub1 = 0;
            int mut1 = 1;
            int div1 = 1;
            int mod1 = 1;

            Console.WriteLine("Enter the first number :");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the first number :");
            num2 = Convert.ToInt16(Console.ReadLine());

            sum1 = (num1 + num2);
            sub1 = (num1 - num2);
            mut1 = (num1 * num2);
            div1 = (num1 / num2);
            mod1 = (num1 % num2);

            Console.WriteLine("Sum of two numbers :" + sum1);
            Console.WriteLine("Subtraction of two numbers :" + sub1);
            Console.WriteLine("Multiplication of two numbers :" + mut1);
            Console.WriteLine("Division of two numbers :" + div1);
            Console.WriteLine("Modulus of two numbers :" + mod1);
            Console.ReadLine();





        }
    }
}
