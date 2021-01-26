using System;

namespace Desafio_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de Datos
            Console.WriteLine("Ingrese el valor de la hipotenusa 't'");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del ángulo 'a' en grados");
            double aG = double.Parse(Console.ReadLine());


            //Proceso y Resultados
            double aR = aG * (Math.PI / 180);

            double y = Math.Sin(aR) * t;            
            Console.WriteLine("El valor del cateto 'y' es: " + Math.Round(y, 3));

            double z = Math.Cos(aR) * t;
            Console.WriteLine("El valor del cateto 'z' es: " + Math.Round(z, 3));

            double c = 90 - aG;
            Console.WriteLine("El valor del ángulo 'c' es: " + c + " grados");
        }
    }
}
