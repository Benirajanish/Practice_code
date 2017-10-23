using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=1;
            int num2=1;
            int result=1;

            Console.WriteLine("Enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = (num1/num2);

            Console.WriteLine("Answer for division : " + result);
            Console.ReadLine();
        }
    }
}
