using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steven
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h;

            Console.Write("Ingrese Base: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la Altura: ");
            h = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"El Area de el rectangulo es: {CalcularArea(b, h)} ");

            Console.ReadLine();

        }
        static double CalcularArea(double b, double h)
        {
            double respuesta = h * b;
            return respuesta;


        }
    }
    }
}
