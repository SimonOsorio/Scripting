using System;

namespace Reto_01___Tarea_Semana_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("         Promedio de Edades");
            Console.WriteLine("-------------------------------------");
            Console.Write("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 0;
            string nombreMin = "", nombreMax = "";
            Console.WriteLine("-------------------------------------");

            while (i < n)
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.Write("Nombre: ");
                string nombreActual = Console.ReadLine();
                Console.WriteLine("-------------------------------------");

                if (i == 0)
                {
                    max = edad;
                    min = edad;
                    nombreMin = nombreActual;
                }
                if (edad > max)
                {
                    max = edad;
                    nombreMax = nombreActual;
                }
                if (edad < min) 
                {
                    min = edad;
                    nombreMin = nombreActual;
                }
                total += edad;
                i++;
            }
            double promedio = total / n;
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Mayor [ Edad: " + max + ", Nombre: " + nombreMax + " ]");
            Console.WriteLine("Menor [ Edad: " + min + ", Nombre: " + nombreMin + " ]");
            Console.WriteLine("-------------------------------------");
        }
    }
}
