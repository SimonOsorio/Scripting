using System;

namespace Reto_02___Tarea_Semana_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("     Cálculo de Cuota Moderadora");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");

            double smmlv = 908526;
            double smdlv = 30284.20;
            double cuota;

            if (salario < smmlv * 2)
            {
                cuota = smdlv * 11.7 / 100; 
                Console.WriteLine("Usted pertenece a la Tarifa A\n(Menos de 2 smmlv)");
                Console.WriteLine("");
                Console.WriteLine("El valor de su cuota moderadora es de:\n            " + Math.Round(cuota, 2) + " pesos");                
            }

            if (salario >= smmlv * 2 && salario < smmlv * 5)
            {
                cuota = smdlv * 46.1 / 100;
                Console.WriteLine("Usted pertenece a la Tarifa B\n(Más de 2 y menos de 5 smmlv)");
                Console.WriteLine("");
                Console.WriteLine("El valor de su cuota moderadora es de:\n            " + Math.Round(cuota, 2) + " pesos");
            }

            if (salario >= smmlv * 5)
            {
                cuota = smdlv * 121.5 / 100;
                Console.WriteLine("Usted pertenece a la Tarifa C\n(Más de 5 smmlv)");
                Console.WriteLine("");
                Console.WriteLine("El valor de su cuota moderadora es de:\n            " + Math.Round(cuota, 2) + " pesos");
            }

            Console.WriteLine("--------------------------------------");

        }
    }
}
