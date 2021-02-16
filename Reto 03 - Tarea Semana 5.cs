using System;

namespace Reto_03___Tarea_Semana_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            int dadoA = 0;
            int nuevoDadoA = 0;
            int totalTemp = 0; 
            int turnCounter = 1;

            Random randomGenerator = new Random();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("           Dados Casa 2");
            Console.WriteLine("------------------------------------");

            dadoA = randomGenerator.Next(1, 13);
            totalTemp = dadoA;
            Console.WriteLine("El dado marca: " + dadoA);
            Console.WriteLine("Lleva un total de: " + totalTemp);            

            while (continua == true)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("¿Desea tirar de nuevo? (S/N)");
                string continuar = Console.ReadLine();
                switch (continuar)
                {
                    case ("S"):
                        continua = true;
                        nuevoDadoA = randomGenerator.Next(1, 13);
                        totalTemp = totalTemp + nuevoDadoA;
                        Console.WriteLine("El dado marca: " + nuevoDadoA);
                        Console.WriteLine("Lleva un total de: " + totalTemp);                        
                        turnCounter += 1;                        
                        if (nuevoDadoA % 2 != 0 && turnCounter > 3)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("     Usted ha perdido el juego");
                            Console.WriteLine("------------------------------------");
                            continua = false;
                        }

                        if (totalTemp >= 100)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("     Usted ha ganado el juego");
                            Console.WriteLine("------------------------------------");
                            continua = false;
                        }
                        if (nuevoDadoA == 12 && turnCounter > 3)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("¿Desea tirar de nuevo? (S/N)");
                            continuar = Console.ReadLine();
                            switch (continuar)
                            {
                                case "S":
                                    continua = true;
                                    nuevoDadoA = randomGenerator.Next(1, 13);
                                    totalTemp = totalTemp + nuevoDadoA;
                                    Console.WriteLine("El dado marca: " + nuevoDadoA);
                                    Console.WriteLine("Lleva un total de: " + totalTemp);
                                    turnCounter += 1;
                                    if (nuevoDadoA == 10)
                                    {
                                        Console.WriteLine("------------------------------------");
                                        Console.WriteLine("     Usted ha ganado el juego");
                                        Console.WriteLine("------------------------------------");
                                        continua = false;
                                    }
                                    break;
                                case "N":
                                    continua = false;
                                    Console.WriteLine("------------------------------------");
                                    Console.WriteLine("        Juego Finalizado");
                                    Console.WriteLine("------------------------------------");
                                    break;

                            }
                            
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
