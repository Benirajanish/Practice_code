using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int num4;
            int avg = 1;

            Console.WriteLine("Enter the first digit :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second digit :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third digit :");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the fourth digit :");
            num4 = Convert.ToInt32(Console.ReadLine());

            avg = ((num1 + num2 + num3 + num4) / 4);

            Console.WriteLine("The Average of " +num1+","+num2+","+num3+","+num4+","+"is :"+ avg);
            Console.ReadLine();


        }
    }
}
