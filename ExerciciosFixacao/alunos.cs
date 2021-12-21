using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuatro
{
    class Alunos
    {
        private string _StudentName;
        private double _Grades;
        public string StudentName { get; set; }
        public double Grades
        {
            get
            {
                return _Grades;
            }
        }
        public void CalcularNotas()
        {
            Console.WriteLine("Digite as três notas do aluno: ");
            for (int contador = 0; contador < 3; contador++)
            {
                _Grades += double.Parse(Console.ReadLine());
            }
        }
        public void VerificarNotas()
        {
            if (_Grades < 60)
            {
                Console.WriteLine("Nota Final: " + _Grades.ToString("F2"));
                Console.WriteLine("Reprovado!");
                _Grades = 60 - _Grades;
                Console.WriteLine("Faltaram " + _Grades.ToString("F2") + " Pontos");
                return;
            }
            else
            {
                Console.WriteLine("Nota final: " + _Grades.ToString("F2"));
                Console.WriteLine("Aprovado!");
            }
        }
    }
}