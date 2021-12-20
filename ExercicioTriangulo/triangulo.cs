using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuatro
{
    class Triangulo
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        private double _p;

        private double _areaTriangulo;
        
        private double CalcularLadoP()
        {
            _p = (LadoA + LadoB + LadoC) / 2.0;
            return _p;
        }

        public double CalcularAreaTriangulo()
        {
            CalcularLadoP();
            _areaTriangulo = Math.Sqrt(_p * (_p - LadoA) * (_p - LadoB) * (_p - LadoC));
            return _areaTriangulo;
        }
    }
}
