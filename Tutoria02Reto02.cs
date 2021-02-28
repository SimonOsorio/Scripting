using System;

namespace Tutoria02Reto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de ecuación cuadrática (ax^2 + bx + c");
            Console.WriteLine("Ingrese el componente a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el componente b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el componente c: ");
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;
            double x, x1, x2;

            if (d == 0)
            {
                x = -b / (2*a);
                Console.WriteLine("El resultado es x = " + x);

            }
            if (d < 0)
            {
                Console.WriteLine("No es posible calcular una solución");
            }
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("El resultado es x1 = " + x1);
                Console.WriteLine("El resultado es x2 = " + x2);
            }

        }
    }
}
