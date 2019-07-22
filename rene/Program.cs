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

            Console.WriteLine(" ingese la altura: ");
            h = double.Parse(Console.ReadLine());

            Console.WriteLine(" ingese la base: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine(calcular(h, b));
            Console.ReadLine();
        }
        static double calcular(double h, double b)
        {

            double respuesta = h * b;

            return respuesta;
        }
    }
}
