using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernando
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1;

            Console.Write("Ingrese el area1: ");
            a1 = double.Parse(Console.ReadLine());

            Console.WriteLine($"El area del cudrado es: " + calcular(a1));
            Console.ReadLine();
        }
        static double calcular(double a1)
        {
            double respuesta = a1 * a1;

            return respuesta;
        }
    }
}
