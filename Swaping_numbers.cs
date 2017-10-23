using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int temp = 0;

            Console.WriteLine("Enter the first number : ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            num2 = Convert.ToInt16(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("Enter the first number : " + num1);
            Console.WriteLine("Enter the second number : " + num2);
            Console.ReadLine();


        }
    }
}
