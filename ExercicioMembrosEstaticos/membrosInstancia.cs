using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuatro
{
    class MembrosInstancia
    {
        public static void ExecutarCalculadora()
        {
            Console.WriteLine("Entre o valor do Raio: ");
            double raioCalc = double.Parse(Console.ReadLine());

            double circCalc = Calculadora.CalculaCircunferencia(raioCalc);
            double volumeCalc = Calculadora.CalculaVolume(raioCalc);

            Console.WriteLine("Circunferencia: " + circCalc.ToString("F2", CultureInfo.CurrentCulture));
            Console.WriteLine("Volume "+ volumeCalc.ToString("F2", CultureInfo.CurrentCulture));
            Console.WriteLine("Valor PI: " + Calculadora.valorPi.ToString("F2", CultureInfo.CurrentCulture));

        }
    }

}
