using System;

namespace Tutoria06Reto01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };
            double[] distancias = new double[estatura.Length];
            int indice = 0;
            double min = 200, total = 0;            
            for (int i = 0; i < estatura.Length; i++) { total += estatura[i]; }
            double promedioEstaturas = total / estatura.Length;
            Console.WriteLine("Promedio de estaturas: " + promedioEstaturas);            
            for (int i = 0; i < estatura.Length; i++)
            {
                distancias[i] = Math.Abs(promedioEstaturas - estatura[i]);
                if (distancias[i] < min) { min = distancias[i]; indice = i;  }                
            }
            Console.WriteLine("Persona con estatura más cercana al promedio: " + nombres[indice] + " (" + estatura[indice] + ")"); ;
        }
    }
}
