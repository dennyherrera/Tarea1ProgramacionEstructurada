using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace William
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;


            Console.Write("ingresar altura: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("ingresar Base: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area = {Area(a, b)}");
            Console.ReadLine();
        }

        static double Area(double a, double b)
        {
            double respuesta = (a * b) / 2;
            return respuesta;

        }
    }
    
}
