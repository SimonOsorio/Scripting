using System;

namespace Reto_02___Tarea_Semana_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            int dadoA = 0;
            int dadoB = 0;
            int nuevoDadoA = 0;
            int nuevoDadoB = 0;
            int totalTemp = 0;
            int pairCounter = 0;
            double turnProm = 0;
            double turnTotal = 1;
            double turnPercent = 0;

            Random randomGenerator = new Random();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("           Dados Casa 1");
            Console.WriteLine("------------------------------------");

            dadoA = randomGenerator.Next(1, 7);
            dadoB = randomGenerator.Next(1, 7);
            totalTemp = dadoA + dadoB;
            Console.WriteLine("Los dados marcan:\n" + dadoA + " y " + dadoB);
            Console.WriteLine("Lleva un total de: " + totalTemp);
            if (dadoA + dadoB > 6)
            {
                turnProm ++;
            }
            if (dadoA == 1 && dadoB == 1)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("     Usted ha perdido el juego");
                Console.WriteLine("------------------------------------");
                continua = false;
            }

            while (continua == true)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("¿Desea tirar de nuevo? (S/N)");
                string continuar = Console.ReadLine();
                switch (continuar)
                {
                    case ("S"):
                        continua = true;
                        nuevoDadoA = randomGenerator.Next(1, 7);
                        nuevoDadoB = randomGenerator.Next(1, 7);
                        totalTemp = totalTemp + nuevoDadoA + nuevoDadoB;
                        Console.WriteLine("Los dados marcan:\n" + nuevoDadoA + " y " + nuevoDadoB);
                        Console.WriteLine("Lleva un total de: " + totalTemp);                        
                        if (nuevoDadoA + nuevoDadoB > 6)
                        {
                            turnProm ++;
                        }
                        if (nuevoDadoB == nuevoDadoA && nuevoDadoB != 1)
                        {
                            pairCounter += 1;
                        }
                        if (totalTemp >= 100 || pairCounter == 3)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("     Usted ha ganado el juego");
                            Console.WriteLine("------------------------------------");
                            continua = false;
                        }
                        if (nuevoDadoA == 1 && nuevoDadoB == 1)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("     Usted ha perdido el juego");
                            Console.WriteLine("------------------------------------");                            
                            continua = false;
                        }
                        turnTotal++;
                        break;                    
                    default:
                        continua = false;                        
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("        Juego Finalizado");
                        Console.WriteLine("------------------------------------");                        
                        break;
                }                
            }
            
            turnPercent = ((turnProm / turnTotal) * 100);
            Console.WriteLine("El porcentaje de veces que sacó una\nsuma mayor a 6 fue de: " + Math.Round(turnPercent, 2) + "% \nsiendo " + turnProm + " turnos en un total de " + turnTotal);
            Console.WriteLine("------------------------------------");
        }
    }
}
