using System;
using System.Collections.Generic;

namespace Reto_01___Tarea_Semana_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba una frase:");
            string frase = Console.ReadLine(), fraseUpper = frase.ToUpper();
            string[] fraseSplit = fraseUpper.Split(' ');
            Console.WriteLine("Escriba una palabra:");
            string palabra = Console.ReadLine(), palabraUpper = palabra.ToUpper();
            int repeticiones = 0;
            List<int> posiciones = new List<int>();
            for (int i = 0; i < fraseSplit.Length; i++)
            {
                if (fraseSplit[i] == palabraUpper)
                {
                    repeticiones++;
                    posiciones.Add(i);
                }
            }
            Console.WriteLine("-------------------------------------");            
            Console.WriteLine("La palabra se ha repetido " + repeticiones + " veces ");
            Console.WriteLine("En las posiciones: ");
            posiciones.ForEach(Console.WriteLine);
        }
    }
}
