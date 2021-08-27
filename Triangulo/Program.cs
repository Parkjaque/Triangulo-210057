using System;
using System.Collections;
using System.Globalization;

namespace Triangulo
{
    class Program


    {
        static void Main(string[] args)
        {
            triangulo x;
            x = new triangulo();

            Console.WriteLine("Coloque as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            triangulo y;
            y = new triangulo();

            Console.WriteLine("Coloque as medidas do triângulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double a = (y.A + y.B + y.C) / 2;
            double areay = Math.Sqrt(a * (a - y.A) * (a - y.B) * (a - y.C));

            Console.WriteLine("Área de y = " + areay.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areay)
            {
                Console.WriteLine("Área do triangulo X é maior do que o Y");
            }
            else if (areaX == areay)
            {
                Console.WriteLine("Área do triangulo X é igual do triangulo Y");
            } else {
                Console.WriteLine("Área do triangulo Y é maior do que o X");
            }

        }

    }
   

}
