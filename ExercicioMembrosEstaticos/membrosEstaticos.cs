using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuatro
{
    class MembrosEstaticos
    {

        static double Pi = 3.14;
        public static void ExecutarExercicioCircunferenciaUm()
        {
            Console.WriteLine("Entre o valor do raio: ");
            double valorRaio = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            double circ = CalcularCircunferencia(valorRaio);
            double volume = CalcularVolume(valorRaio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.CurrentCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double CalcularCircunferencia(double raioExterno)
        {
            return 2 * Pi * raioExterno;
        }
        static double CalcularVolume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}