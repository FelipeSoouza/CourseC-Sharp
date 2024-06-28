using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OB_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo x:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.WriteLine("Entre com as medidas do triângulo y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
