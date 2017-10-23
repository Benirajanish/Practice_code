using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Enter your age - ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You look older than " + num1);
            Console.ReadLine();
        }
    }
}
