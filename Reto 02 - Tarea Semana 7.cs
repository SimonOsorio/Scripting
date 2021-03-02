using System;

namespace Reto_02___Tarea_Semana_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            int dado = 0;
            int dado2 = 0;
            int totalTemp = 0;
            int vidas = 3;
            int contadorTurnos = 1;

            Random randomGenerator = new Random();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("           Juego de Dados 2");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  Cada 3 turnos puede usar 2 dados\n   y cada 2 turnos pierde 1 vida.");
            Console.WriteLine("------------------------------------");
            dado = randomGenerator.Next(1, 7);
            totalTemp = dado;
            Console.WriteLine("El dado marca: " + dado);
            Console.WriteLine("Lleva un total de: " + totalTemp);
            Console.WriteLine("Vidas restantes: " + vidas);
            Console.WriteLine("Turno: " + contadorTurnos);
            contadorTurnos++;


            while (continua == true)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("¿Desea tirar de nuevo? (S/N)");
                string continuar = Console.ReadLine();
                Console.WriteLine("------------------------------------");
                switch (continuar)
                {
                    case ("S"):
                        continua = true;
                        dado = randomGenerator.Next(1, 7);
                        if (contadorTurnos % 2 == 0) { vidas -= 1; }
                        if (contadorTurnos % 3 == 0)
                        {
                            dado2 = randomGenerator.Next(1, 7);
                            totalTemp += dado + dado2;
                            Console.WriteLine("Pasaron 3 turnos (tira 2 dados):\nEl dado 1 marca: " + dado + "\nEl dado 2 marca: " + dado2 );
                            if(dado == dado2) { if (vidas < 3) { vidas++; } }
                        }
                        else
                        {                            
                            totalTemp += dado;
                            Console.WriteLine("El dado marca: " + dado);                            
                        }
                        Console.WriteLine("Lleva un total de: " + totalTemp);
                        Console.WriteLine("Vidas restantes: " + vidas);
                        Console.WriteLine("Turno: " + contadorTurnos);
                        contadorTurnos++;
                        if (totalTemp >= 100)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("     Usted ha ganado el juego");
                            Console.WriteLine("------------------------------------");
                            continua = false;
                        }
                        if (vidas <= 0)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("      Se ha quedado sin vidas:");
                            Console.WriteLine("        ha perdido el juego");
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Le han faltado " + (100 - totalTemp) + " puntos.");
                            continua = false;
                        }
                        break;
                    default:
                        continua = false;
                        Console.WriteLine("        Juego Finalizado");
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Le han faltado " + (100 - totalTemp) + " puntos.");
                        break;
                }
            }
            Console.WriteLine("------------------------------------");
        }
    }
}
