using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int result = 1;

            Console.WriteLine("Multiplication of the number :" );
            num1 = Convert.ToInt16(Console.ReadLine());

            for (Int16 i = 0; i <= 10; i++)
            {
                result = (num1 * i);


                Console.WriteLine(num1+ "*" + i+"="+result);
            }
            
            Console.ReadLine();



        }
    }
}
