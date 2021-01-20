using System;

namespace Reto1Tutoria1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las primeras coordenadas (Xa, Ya) Respectivamente");
            Console.WriteLine("Xa:");
            double Xa = double.Parse(Console.ReadLine());
            Console.WriteLine("Ya:");
            double Ya = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las segundas coordenadas (Xb, Yb) Respectivamente");
            Console.WriteLine("Xb:");
            double Xb = double.Parse(Console.ReadLine());
            Console.WriteLine("Yb:");
            double Yb = double.Parse(Console.ReadLine());

            double m = (Yb - Ya) / (Xb - Xa);
            Console.WriteLine("La pendiente es: " + m);

            double b = Ya - m * Xa;
            Console.WriteLine("El intercepto es: " + b);
            
            double d = Math.Sqrt((Xb - Xa)*(Xb - Xa) + (Yb - Ya)*(Yb - Ya));
            Console.WriteLine("La distancia entre los puntos es: " + d);
           
        }
    }
}
