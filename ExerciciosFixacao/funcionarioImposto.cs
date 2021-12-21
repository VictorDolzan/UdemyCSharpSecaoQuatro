using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuatro
{
    class FuncionarioImposto
    {
        private string _NomeFuncionarioImposto;
        private double _SalarioBruto;
        private double _Imposto;
        // private double _SalarioLiquido;
        // public double valorFinal;

        public double Imposto 
        {
            get
            {
                return _Imposto;
            }
            set
            {
                _Imposto = value;
            }
        }

        public string NomeFuncionarioImposto
        {
            get
            {
                return _NomeFuncionarioImposto;
            }
            set
            {
                _NomeFuncionarioImposto = value;
            }
        }

        public double SalarioBruto 
        {
            get
            {
                return _SalarioBruto;
            }
            set
            {
                _SalarioBruto = value;
            }
        }

        public double SalarioLiquido()
        {
             return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagemExterna)
        {
             SalarioBruto += (SalarioBruto * porcentagemExterna / 100.0) ;           
        }

        public override string ToString()
        {
            return _NomeFuncionarioImposto
            + ", R$"
            + SalarioLiquido().ToString("F2", CultureInfo.CurrentCulture);
        }
    }
}