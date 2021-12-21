using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuatro
{
    class ExercicioEstoque
    {
        public static void ExecutarExercicioEstoque()
        {
           Produto prod1 = new Produto();                      
           
           Console.WriteLine("Entre com os dados do produto: ");
           Console.WriteLine("Nome: ");
           prod1.NomeProduto = Console.ReadLine();
           Console.WriteLine($"Digite o preço do {prod1.NomeProduto}: ");
           prod1.PrecoProduto = double.Parse(Console.ReadLine());
           Console.WriteLine($"Digite quantos produtos serão adicionados: ");
           prod1.AdicionarProdutos(int.Parse(Console.ReadLine()));

           Console.WriteLine("Dados do produto: " + prod1); 
           
           Console.WriteLine();
           Console.Write($"Digite quantos produtos do {prod1.NomeProduto} serão adicionados: ");
           prod1.AdicionarProdutos(int.Parse(Console.ReadLine()));
           Console.WriteLine("Dados Atualizados: "+ prod1);

           Console.WriteLine();
           Console.Write($"Digite quantos produtos do {prod1.NomeProduto} serão removidos: ");
           prod1.RemoverProdutos(int.Parse(Console.ReadLine()));
           Console.WriteLine("Dados Atualizados: "+ prod1);


        
        }
    }
}