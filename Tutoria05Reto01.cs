using System;

namespace Tutoria05Reto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int sumaCorrecta = 1;
            int suma = 0;
            int counter = 0;
            Console.WriteLine("Captcha: Ingrese la suma de los 2 dígitos: ");

            while (suma != sumaCorrecta)
            {
                if (counter < 3)
                {
                    int a = randomGenerator.Next(1, 11);
                    int b = randomGenerator.Next(1, 11);
                    Console.WriteLine(a + " + " + b);
                    sumaCorrecta = a + b;
                    suma = int.Parse(Console.ReadLine());
                    counter += 1;
                    if (suma != sumaCorrecta)
                    {
                        Console.WriteLine("Entrada errónea, vuelva a intentarlo");
                        Console.WriteLine((3 - counter) + " intentos restantes");
                    }
                }
                else
                {
                    Console.WriteLine("No tiene más intentos");
                    counter += 1;
                    suma = sumaCorrecta;
                }
            }

            if (counter <= 3)
            {
                Console.WriteLine("Entrada satisfactoria");
            }
        }
    }
}
