using System;

namespace Reto_01___Tarea_Semana_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            int dado = 0;
            int totalTemp = 0;
            int vidas = 3;
            int contador1s = 0;
            int contador6s = 0;
            int dadosEsp = 2;
            int dadoEsp = 0;

            Random randomGenerator = new Random();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("           Juego de Dados ");
            Console.WriteLine("------------------------------------");
            dado = randomGenerator.Next(1, 7);
            dadoEsp = randomGenerator.Next(1, 13);
            Console.WriteLine("¿Desea usar un dado especial? (S/N)\nDispone de: " + dadosEsp);
            string usarDadoEsp = Console.ReadLine();
            Console.WriteLine("------------------------------------");
            switch (usarDadoEsp)
            {
                case ("S"):
                    dadosEsp -= 1;
                    totalTemp = dadoEsp;
                    Console.WriteLine("El dado marca: " + dadoEsp);
                    break;
                default:
                    totalTemp = dado;
                    Console.WriteLine("El dado marca: " + dado);
                    break;
            }
            Console.WriteLine("Lleva un total de: " + totalTemp);
            Console.WriteLine("Vidas restantes: " + vidas);

            if (totalTemp == 1) { contador1s++; }
            if (totalTemp == 6) { contador6s++; }

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
                        if (dadosEsp > 0)
                        {
                            Console.WriteLine("¿Desea usar un dado especial? (S/N)\nLe quedan: " + dadosEsp);
                            usarDadoEsp = Console.ReadLine();
                            Console.WriteLine("------------------------------------");
                            switch (usarDadoEsp)
                            {
                                case ("S"):
                                    dado = 0;
                                    dadoEsp = randomGenerator.Next(1, 13);
                                    dadosEsp -= 1;
                                    totalTemp += dadoEsp;
                                    Console.WriteLine("El dado marca: " + dadoEsp);
                                    break;
                                default:
                                    dadoEsp = 0;
                                    dado = randomGenerator.Next(1, 7);
                                    totalTemp += dado;
                                    Console.WriteLine("El dado marca: " + dado);
                                    break;
                            }
                        }
                        else { dadoEsp = 0; dado = randomGenerator.Next(1, 7); totalTemp += dado; Console.WriteLine("El dado marca: " + dado); }
                        Console.WriteLine("Lleva un total de: " + totalTemp);

                        if (dado == 1 || dadoEsp == 1)
                        {
                            contador1s++;
                            if (contador1s == 2) { vidas -= 1; contador1s = 0; totalTemp -= 10; Console.WriteLine("\nHa perdido una vida por sacar '1'\ndos veces. Pierde 10 puntos.\n"); }
                        }
                        if (dado == 6 || dadoEsp == 6) { contador6s++; } else { contador6s = 0; }
                        if (contador6s >= 2)
                        {
                            if (vidas < 3) { vidas++; contador6s = 0; Console.WriteLine("\nHa recuperado una vida por sacar\n'6' dos veces consecutivas.\n"); }
                        }
                        Console.WriteLine("Vidas restantes: " + vidas);
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
