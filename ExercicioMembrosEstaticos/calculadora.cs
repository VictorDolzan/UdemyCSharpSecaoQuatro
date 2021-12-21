using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuatro
{
    class Calculadora 
    {
        public static double valorPi = 3.14;

        public static double CalculaCircunferencia(double r)
        {
            return 2.0 * valorPi * r;
        }
        public static double CalculaVolume(double r)
        {
            return 4.0 / 3.0 * valorPi * Math.Pow(r, 3.0);
        }
    }
}