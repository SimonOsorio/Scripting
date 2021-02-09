using System;

namespace Reto_01___Tarea_Semana_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("         Cálculo de Deducciones");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Ingrese su salario base en pesos: ");
            double salarioBase = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            double smmlv = 908526;
            double cotizacion = salarioBase * 0.4;
            double pension = 0;
            double EPS = 0;
            double ARL = 0;
            double valorRiesgo = 0;

            if (cotizacion <= smmlv)
            {
                cotizacion = smmlv;
            }            

            Console.WriteLine("    Escriba '1' si es Dependiente\n     o '2'si es Independiente:");
            int contrato = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            switch (contrato)
            {
                case 1:
                    Console.WriteLine("          Sus deducciones son:");
                    Console.WriteLine("------------------------------------------");
                    pension = cotizacion * 0.04;
                    Console.WriteLine("Pensión: " + pension);

                    EPS = cotizacion * 0.04;
                    Console.WriteLine("EPS: " + EPS);

                    ARL = cotizacion * 0;
                    Console.WriteLine("ARL: " + ARL);

                    double prima = salarioBase;
                    double deducciones = pension + EPS + ARL;
                    double salarioTotal = salarioBase - deducciones;

                    double salarioAnual = (salarioTotal * 12) + prima;
                    Console.WriteLine("Su salario anual es de: " + Math.Round(salarioAnual, 2) + " pesos");
                    break;
                case 2:
                    Console.WriteLine("Ingrese su clase de Riesgo de ARL: ");
                    int riesgo = int.Parse(Console.ReadLine());
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("          Sus deducciones son:");
                    Console.WriteLine("------------------------------------------");

                    pension = cotizacion * 0.16;
                    Console.WriteLine("Pensión: " + pension);

                    EPS = cotizacion * 0.125;
                    Console.WriteLine("EPS: " + EPS);

                    switch (riesgo)
                    {
                        case 1: valorRiesgo = 0.00522; break;
                        case 2: valorRiesgo = 0.01044; break;
                        case 3: valorRiesgo = 0.02436; break;
                        case 4: valorRiesgo = 0.04350; break;
                        case 5: valorRiesgo = 0.06960; break;
                    }

                    ARL = cotizacion * valorRiesgo;
                    Console.WriteLine("ARL: " + ARL);

                    deducciones = pension + EPS + ARL;
                    salarioTotal = salarioBase - deducciones;

                    salarioAnual = salarioTotal * 12;
                    Console.WriteLine("Su salario anual es de: " + Math.Round(salarioAnual, 2) + " pesos");
                    Console.WriteLine("------------------------------------------");
                    break;

            }          
        }
    }
}
