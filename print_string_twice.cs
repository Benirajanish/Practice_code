using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Enter a digit :");
            num1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1;i<= 2; i++)
            {
                
              Console.WriteLine(num1 + " " + num1 + " " + num1 + " " + num1);
                
              Console.WriteLine(num1+""+num1+""+num1+""+num1);     

             }

            Console.ReadLine();
         }
    }
}
