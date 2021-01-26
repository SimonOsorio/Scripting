using System;

namespace Desafio_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de Datos
            Console.WriteLine("Ingrese el valor del cateto 'y'");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del cateto 'z'");
            double z = double.Parse(Console.ReadLine());

            //Proceso y Resultados
            double t = Math.Sqrt(z * z + y * y);
            Console.WriteLine("El valor de la hipotenusa 't' es: " + Math.Round(t, 3));

            double aR = Math.Asin(y / t);
            double aG = aR * (180 / Math.PI);
            Console.WriteLine("El valor del ángulo 'a' es: " + Math.Round(aG, 3) + " grados");

            double cR = Math.Asin(z / t);
            double cG = cR * (180 / Math.PI);
            Console.WriteLine("El valor del ángulo 'c' es: " + Math.Round(cG, 3) + " grados");
        }
    }
}
