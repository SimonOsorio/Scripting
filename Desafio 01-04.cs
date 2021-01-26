using System;

namespace Desafio_01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor del ángulo 'b' en grados: ");
            double bG = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del cateto 'z': ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del cateto 'y': ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double bR = bG * (MathF.PI / 180);
            double aR = Math.Atan(y / z);
            double x = Math.Tan(aR + bR) * z - y;
            Console.WriteLine("El valor del segmento 'x' es: " + Math.Round(x, 2));

            Console.WriteLine("---------------------------------------------------");

            Console.Write("Ingrese el valor del ángulo 'b' en grados: ");
            bG = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del ángulo 'd' en grados: ");
            double dG = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del cateto 'y': ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double aG = 90 - dG - bG;
            z = y / Math.Tan(aR);
            Console.WriteLine("El valor del cateto 'z' es: " + Math.Round(z,2));

            Console.WriteLine("---------------------------------------------------");

            Console.Write("Ingrese el valor de la hipotenusa 'w': ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del ángulo 'd' en grados: ");
            dG = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del segmento 'x': ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double dR = dG * (Math.PI / 180);
            y = Math.Cos(dR) * w - x;
            Console.WriteLine("El valor del cateto 'y' es: " + Math.Round(y, 2));

            Console.WriteLine("---------------------------------------------------");

            Console.Write("Ingrese el valor de la hipotenusa 'w': ");
            w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de la hipotenusa 't': ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del ángulo 'c' en grados: ");
            double cG = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double cR = cG * (Math.PI / 180);
            z = Math.Sin(cR) * t;
            dR = Math.Asin(z / w);
            y = z / Math.Tan(cR);
            x = Math.Cos(dR) * w - y;
            Console.WriteLine("El valor del segmento 'x' es: " + Math.Round(x, 2));
        }
    }
}
