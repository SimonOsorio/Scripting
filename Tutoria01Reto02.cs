using System;

namespace Tutoria01Reto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC\n");
            Console.Write("Ingrese su peso (Kg): ");
            double w = double.Parse(Console.ReadLine());

            Console.Write("Ingrese su altura (m): ");
            double h = double.Parse(Console.ReadLine());

            double IMC = w / (h * h);

            Console.WriteLine("Su IMC es: " + IMC);


            if (IMC < 18.5)
            {
                Console.WriteLine("Su peso es inferior al normal");
            }
            if (18.5 < IMC && IMC < 24.9)
            {
                Console.WriteLine("Su peso es normal");
            }
            if (24.9 < IMC && IMC <= 29.9)
            {
                Console.WriteLine("Su peso es superior al normal");
            }
            if (30 <= IMC)
            {
                Console.WriteLine("Usted sufre de obesidad");
            }




        }
    }
}
