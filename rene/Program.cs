using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rene
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, b;

            Console.WriteLine(" ingese la altura del ronboide: ");
            h = double.Parse(Console.ReadLine());

            Console.WriteLine(" ingese la base del ronboide: ");
            b = double.Parse(Console.ReadLine());



            Console.WriteLine($"el area del ronboide: "+calcular(h, b));
            Console.ReadLine();
        }
        static double calcular(double h, double b)
        {

            double respuesta = h * b;

            return respuesta;
        }
    }
}
