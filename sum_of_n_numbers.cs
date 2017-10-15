using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_n_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 =0;
            int sum1 = 0;
           
            

            Console.WriteLine("Enter the number : ");
            num1 = Convert.ToInt16(Console.ReadLine());

            for (Int16 i = 0; i <= num1; i++)
            {
                sum1 = (sum1 + i);
            }   
                Console.WriteLine("Sum of n numbers : " + sum1);
                Console.ReadLine();
            
        }

    }
}
