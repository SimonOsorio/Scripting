using System;

namespace Tutoria04Reto01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            int cartaA = 0;
            int cartaB = 0;
            int nuevaCarta = 0;
            int totalTemp = 0;            

            Random randomGenerator = new Random();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("           Blackjack");
            Console.WriteLine("------------------------------------");

            cartaA = randomGenerator.Next(1, 11);
            cartaB = randomGenerator.Next(1, 11);
            totalTemp = cartaA + cartaB;
            Console.WriteLine("Sus cartas son:\n" + cartaA + " y " + cartaB);
            Console.WriteLine("Lleva un total de: " + totalTemp);


            while (continua == true)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("¿Desea más cartas? (S/N)");
                string continuar = Console.ReadLine();
                switch (continuar)
                {
                    case ("S"):
                        continua = true;
                        nuevaCarta = randomGenerator.Next(1, 10);
                        totalTemp = totalTemp + nuevaCarta;
                        Console.WriteLine("Su nueva carta es: " + nuevaCarta);
                        Console.WriteLine("Lleva un total de: " + totalTemp);
                        if (totalTemp == 21)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("     Usted ha ganado el juego");
                            Console.WriteLine("------------------------------------");
                            continua = false;
                        }
                        if (totalTemp > 21)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("     Usted ha perdido el juego");
                            Console.WriteLine("------------------------------------");
                            continua = false;
                        }
                        break;
                    case ("s"):
                        continua = true;
                        nuevaCarta = randomGenerator.Next(1, 10);
                        totalTemp = totalTemp + nuevaCarta;
                        Console.WriteLine("Su nueva carta es: " + nuevaCarta);
                        Console.WriteLine("Lleva un total de: " + totalTemp);
                        if (totalTemp == 21)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("     Usted ha ganado el juego");
                            Console.WriteLine("------------------------------------");
                            continua = false;
                        }
                        if (totalTemp > 21)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("     Usted ha perdido el juego");
                            Console.WriteLine("------------------------------------");
                            continua = false;
                        }
                        break;
                    default:
                        continua = false;
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("        Juego Finalizado");
                        Console.WriteLine("------------------------------------");
                        break;
                }

            }
        }
    }
}
