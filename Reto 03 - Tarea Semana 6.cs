using System;

namespace Reto_03___Tarea_Semana_6
{
    class Program
    {
        static double Factorial(double valor)
        {
            double total = 1;
            for (int i = 1; i <= valor; i++)
            {
                total *= i;
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 'x' para calcular sin(x):");
            double x = double.Parse(Console.ReadLine());
            int n = 100;
            double sin = 0;

            for (int i = 0; i <= n; i++)
            {
                sin += ((Math.Pow(-1, i) / Factorial(2*i+1))*Math.Pow(x,2*i+1));
            }

            Console.WriteLine("La respuesta es: " + Math.Round(sin, 3));
        }
    }
}
