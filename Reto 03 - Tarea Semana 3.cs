using System;

namespace Reto_03___Tarea_Semana_3
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
            double cotizacion = 0;
            double pension = 0;
            double EPS = 0;
            double ARL = 0;
            double valorRiesgo = 0;

            if (salarioBase >= smmlv)
            {
                cotizacion = salarioBase * 0.4;
            }
            if (salarioBase < smmlv)
            {
                cotizacion = smmlv;                
            }

            Console.WriteLine("    Escriba 'true' si es Dependiente\n     o 'false'si es Independiente:");            
            bool contrato = bool.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");            

            if (contrato == true)
            {
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
                Console.WriteLine("Su salario anual es de: " + salarioAnual + " pesos");
            }
            if (contrato == false)
            {
                Console.WriteLine("Ingrese su clase de Riesgo de ARL: ");
                int riesgo = int.Parse(Console.ReadLine());

                Console.WriteLine("          Sus deducciones son:");
                Console.WriteLine("------------------------------------------");

                pension = cotizacion * 0.16;
                Console.WriteLine("Pensión: " + pension);

                EPS = cotizacion * 0.125;
                Console.WriteLine("EPS: " + EPS);

                if (riesgo == 1) { valorRiesgo = 0.00522; }
                if (riesgo == 2) { valorRiesgo = 0.01044; }
                if (riesgo == 3) { valorRiesgo = 0.02436; }
                if (riesgo == 4) { valorRiesgo = 0.04350; }
                if (riesgo == 5) { valorRiesgo = 0.06960; }

                ARL = cotizacion * valorRiesgo;
                Console.WriteLine("ARL: " + ARL);

                double deducciones = pension + EPS + ARL;
                double salarioTotal = salarioBase - deducciones;

                double salarioAnual = salarioTotal * 12;
                Console.WriteLine("Su salario anual es de: " + salarioAnual + " pesos");
                Console.WriteLine("------------------------------------------");
            }
        }
    } 
}
