using System;

namespace Reto_02___Tarea_Semana_6
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
            Console.WriteLine("Ingrese 'x' para calcular e^x:");
            double x = double.Parse(Console.ReadLine());
            int n = 100;
            double euler = 0;
            
            for(int i = 0; i <= n; i++)
            {
                euler += (Math.Pow(x, i)/Factorial(i));
            }

            Console.WriteLine("La respuesta es: " + Math.Round(euler, 3));            
        }
    }
}
