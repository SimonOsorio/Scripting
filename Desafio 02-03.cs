using System;

namespace Desafio_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de Datos
            Console.WriteLine("Ingrese el valor del cateto 'z'");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del ángulo 'c' en grados");
            double cG = double.Parse(Console.ReadLine());


            //Proceso y Resultados
            double cR = cG * (Math.PI / 180);

            double t = z / Math.Sin(cR);
            Console.WriteLine("El valor de la hipotenusa 't' es: " + Math.Round(t, 3));

            double y = Math.Cos(cR) * t;
            Console.WriteLine("El valor del cateto 'y' es: " + Math.Round(y, 3));

            double a = 90 - cG;
            Console.WriteLine("El valor del ángulo 'a' es: " + a + " grados");
        }
    }
}
