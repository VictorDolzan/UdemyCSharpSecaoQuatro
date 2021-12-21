using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuatro.PrimeirosExercicios
{
    class PrimeirosExercicios
    {
        public static void ExecutarExercicioPessoas()
        {
            Pessoas Maria = new Pessoas();
            Pessoas Joao = new Pessoas();
            int maiorIdade;

            Joao.NomePessoa = "João";
            Joao.IdadePessoa = 18;

            Maria.NomePessoa = "Maria";
            Maria.IdadePessoa = 17;

            Console.WriteLine($"Dados da primeira pessoa: ");
            Console.WriteLine($"Nome: {Maria.NomePessoa}");
            Console.WriteLine($"Idade: {Maria.IdadePessoa}");

            Console.WriteLine($"Dados da segunda pessoa: ");
            Console.WriteLine($"Nome: {Joao.NomePessoa}");
            Console.WriteLine($"Idade: {Joao.IdadePessoa}");
           

            if(Joao.IdadePessoa > Maria.IdadePessoa)
            {
                Console.WriteLine($"Pessoa mais velha é: {Joao.NomePessoa}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha é: {Maria.NomePessoa}");
            }
        }

        public static void ExecutarExercicioFuncionarios()
        {
            Funcionarios Carlos = new Funcionarios();
            Funcionarios Ana = new Funcionarios();
            double mediaSalario;

            Carlos.NomeFuncionario = "Carlos Silva";
            Carlos.SalarioFuncionario = 6300.00;

            Ana.NomeFuncionario = "Ana Marques";
            Ana.SalarioFuncionario = 6700.00;

            mediaSalario = (Carlos.SalarioFuncionario + Ana.SalarioFuncionario) / 2.0;

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.WriteLine($"Nome: {Carlos.NomeFuncionario}");
            Console.WriteLine($"Salário: {Carlos.SalarioFuncionario}");

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine($"Nome: {Ana.NomeFuncionario}");
            Console.WriteLine($"Salário: {Ana.SalarioFuncionario}");

            Console.WriteLine($"Salário Médio: {mediaSalario}");
        }
    }
}