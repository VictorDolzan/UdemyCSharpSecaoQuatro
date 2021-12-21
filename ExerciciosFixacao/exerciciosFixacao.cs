using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuatro
{
    class ExerciciosFixacao
    {
        public static void ExecutarExercicioImposto()
        {
            FuncionarioImposto func1 = new FuncionarioImposto();

            Console.Write("Nome: ");
            func1.NomeFuncionarioImposto = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func1.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func1);
            
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            func1.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func1 );


        }

        public static void ExecutarExercicioAluno()
        {
            Alunos Alex = new Alunos();

            Console.Write("Nome do aluno: ");
            Alex.StudentName = Console.ReadLine();

            Alex.CalcularNotas();
            Alex.VerificarNotas();
            

        }
    }
}