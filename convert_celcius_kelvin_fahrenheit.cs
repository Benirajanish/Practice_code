using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            double kelvin;
            double fahrenheit;
            double celcius;

            Console.WriteLine("Enter celcius :");
            celcius = Convert.ToDouble(Console.ReadLine());

            kelvin = (celcius +273);

            fahrenheit =(1.8 * celcius) +32;


            Console.WriteLine("Kelvin = " + kelvin);
            Console.WriteLine("Fahrenheit = " + fahrenheit);

            Console.ReadLine();
        }
    }
}
