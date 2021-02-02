using System;

namespace Reto_01___Tarea_Semana_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("      Cálculo de Tarifa");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            double smmlv = 908526;

            if (salario < smmlv * 2)
            {
                Console.WriteLine("Usted pertenece a la Tarifa A\n(Menos de 2 smmlv)");
            }

            if (salario >= smmlv * 2 && salario < smmlv * 4)
            {
                Console.WriteLine("Usted pertenece a la Tarifa B\n(Más de 2 y menos de 4 smmlv)");
            }

            if (salario >= smmlv * 4)
            {
                Console.WriteLine("Usted pertenece a la Tarifa C\n(Más de 4 smmlv)");
            }

            Console.WriteLine("------------------------------");

        }
    }
}
