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
            double bas, alt;

            Console.Write("Ingrese Base: ");
            bas = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la Altura: ");
            alt = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"El Area de el rectangulo es: {CalcularArea(bas, alt)} ");

            Console.ReadLine();

        }
        static double CalcularArea(double bas, double alt)
        {
            double respuesta = bas * alt;
            return respuesta;


        }
    }
    
}
