using System;

namespace Reto_01___Tarea_Semana_6
{
    class Program
    {
        static void BlackJackLetrero()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("              Blackjack");
            Console.WriteLine("------------------------------------");
        }

        static void Main(string[] args)
        {
            bool continua = true;
            int cartaA = 0;
            int cartaB = 0;
            int nuevaCarta = 0;
            int cantJugadores = 0;
            bool numJugCorrecta = false;
            int[] totales = new int[5];
            string[] ganadores = new string[5];

            Random randomGenerator = new Random();

            while (numJugCorrecta == false)
            {
                BlackJackLetrero();
                Console.WriteLine("¿Cuántas personas van a jugar? [2-5]");
                int numJugadores = int.Parse(Console.ReadLine());
                cantJugadores = numJugadores;

                if (numJugadores >= 2 && numJugadores <= 5) { numJugCorrecta = true; Console.Clear(); }
                else
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("   Error: Deben haber mínimo 2\n       y máximo 5 jugadores\n ");
                    Console.WriteLine("Pulse 'Enter' para continuar");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    Console.Clear();
                }
            }

            for (int i = 1; i <= cantJugadores; i++)
            {
                cartaA = randomGenerator.Next(1, 11);
                cartaB = randomGenerator.Next(1, 11);
                if (i == 1 || i == 2 || i == 3 || i == 4 || i == 5) { totales[i - 1] = cartaA + cartaB; }
                BlackJackLetrero();
                Console.WriteLine("Jugador actual: " + i + "/" + cantJugadores);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Sus cartas son:\n" + cartaA + " y " + cartaB);
                Console.WriteLine("Lleva un total de: " + totales[i - 1]);
                continua = true;

                while (continua == true)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("¿Desea más cartas? (S/N)");
                    string continuar = Console.ReadLine();

                    while (continuar != "S" && continuar != "N")
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Entrada errónea (S/N)");
                        continuar = Console.ReadLine();
                    }

                    switch (continuar)
                    {
                        case ("S"):
                            continua = true;
                            nuevaCarta = randomGenerator.Next(1, 10);
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Su nueva carta es: " + nuevaCarta);
                            if (i == 1 || i == 2 || i == 3 || i == 4 || i == 5) { totales[i - 1] += nuevaCarta; }
                            Console.WriteLine("Lleva un total de: " + totales[i - 1]);

                            if (totales[i - 1] == 21)
                            {
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine("     Usted ha ganado el juego");
                                Console.WriteLine("------------------------------------");
                                ganadores[i - 1] = "Sí";
                                continua = false;
                                Console.WriteLine("Pulse 'Enter' para continuar");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                Console.Clear();
                            }
                            if (totales[i - 1] > 21)
                            {
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine("     Usted ha perdido el juego");
                                Console.WriteLine("------------------------------------");
                                ganadores[i - 1] = "No";
                                continua = false;
                                Console.WriteLine("Pulse 'Enter' para continuar");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                                Console.Clear();
                            }
                            break;
                        default:
                            continua = false;
                            ganadores[i - 1] = "No";
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("        Turno Finalizado");
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Pulse 'Enter' para continuar");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                            Console.Clear();
                            break;
                    }
                }
            }

            BlackJackLetrero();
            Console.WriteLine("Total del Jugador 1: " + totales[0]);
            Console.WriteLine("Total del Jugador 2: " + totales[1]);
            if (cantJugadores > 2) { Console.WriteLine("Total del Jugador 3: " + totales[2]); }
            if (cantJugadores > 3) { Console.WriteLine("Total del Jugador 4: " + totales[3]); }
            if (cantJugadores > 4) { Console.WriteLine("Total del Jugador 5: " + totales[4]); }
            int ganadorNom = 0, ganadorCant = 0;
            for (int a = 0; a <= (cantJugadores - 1); a++)
            {
                if (a == 0)
                {
                    ganadorCant = totales[a];
                }
                if (totales[a] > ganadorCant)
                {
                    ganadorCant = totales[a];
                }
                if (totales[0] == ganadorCant) { ganadorNom = 1; }
                if (totales[1] == ganadorCant) { ganadorNom = 2; }
                if (totales[2] == ganadorCant) { ganadorNom = 3; }
                if (totales[3] == ganadorCant) { ganadorNom = 4; }
                if (totales[4] == ganadorCant) { ganadorNom = 5; }
            }

            Console.WriteLine("------------------------------------");

            if (totales[0] < 21 && totales[1] < 21 && totales[2] < 21 && totales[3] < 21 && totales[4] < 21)
            {
                Console.WriteLine("Ganador: Jugador " + ganadorNom);
                Console.WriteLine("Y/O quien haya conseguido: " + ganadorCant + " puntos");
            }
            else
            {
                Console.Clear();
                BlackJackLetrero();
                Console.WriteLine("Total del Jugador 1:      Ganó (21): \n        " + totales[0] + "                     " + ganadores[0]);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Total del Jugador 2:      Ganó (21): \n        " + totales[1] + "                     " + ganadores[1]);
                Console.WriteLine("------------------------------------");
                if (cantJugadores > 2)
                {
                    Console.WriteLine("Total del Jugador 3:      Ganó (21): \n        " + totales[2] + "                     " + ganadores[2]);
                    Console.WriteLine("------------------------------------");
                }
                if (cantJugadores > 3)
                {
                    Console.WriteLine("Total del Jugador 4:      Ganó (21): \n        " + totales[3] + "                     " + ganadores[3]);
                    Console.WriteLine("------------------------------------");
                }
                if (cantJugadores > 4)
                {
                    Console.WriteLine("Total del Jugador 5:      Ganó (21): \n        " + totales[4] + "                     " + ganadores[4]);
                    Console.WriteLine("------------------------------------");
                }

                bool[] ganYper = new bool[5];
                int[] totales2 = new int[5];
                for (int f = 0; f <= (cantJugadores - 1); f++)
                {
                    if (ganadores[f] == "No" || totales[f] > 21)
                    {
                        ganYper[f] = false;
                        totales2[f] = 0;
                    }
                    if (ganadores[f] == "Si")
                    {
                        ganYper[f] = true;
                        totales2[f] = totales[f];
                    }
                    if (totales[f] <= 21)
                    {
                        ganYper[f] = true;
                        totales2[f] = totales[f];
                    }
                }
                ganadorNom = 0; ganadorCant = 0;
                for (int a = 0; a <= (cantJugadores - 1); a++)
                {
                    if (a == 0)
                    {
                        ganadorCant = totales2[a];
                    }
                    if (totales2[a] > ganadorCant)
                    {
                        ganadorCant = totales2[a];
                    }
                    if (totales2[0] == ganadorCant) { ganadorNom = 1; }
                    if (totales2[1] == ganadorCant) { ganadorNom = 2; }
                    if (totales2[2] == ganadorCant) { ganadorNom = 3; }
                    if (totales2[3] == ganadorCant) { ganadorNom = 4; }
                    if (totales2[4] == ganadorCant) { ganadorNom = 5; }
                }

                Console.WriteLine("Ganador por puntaje: Jugador " + ganadorNom);
                Console.WriteLine("Y/O quien haya conseguido: " + ganadorCant + " puntos");
                Console.WriteLine(" \n ");
            }
        }
    }
}