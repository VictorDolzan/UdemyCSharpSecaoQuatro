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
           
           prod1.NomeProduto = "Produto 1";

           Console.WriteLine($"Digite o preço do {prod1.NomeProduto}: ");
           prod1.PrecoProduto = double.Parse(Console.ReadLine());
           Console.WriteLine($"Digite quantos produtos serão adicionados: ");
           prod1.AdicionarProdutos(int.Parse(Console.ReadLine()));

           Console.WriteLine($"Quantidade do {prod1.NomeProduto} é: {prod1.ValorTotalEmEstoque()}"); 
           
           Console.WriteLine($"Digite quantos produtos do {prod1.NomeProduto} serão removidos: ");
           prod1.RemoverProdutos(int.Parse(Console.ReadLine()));

           Console.WriteLine($"Quantidade do {prod1.NomeProduto} agora é: {prod1.ValorTotalEmEstoque()}");
           Console.WriteLine($"Valor total do {prod1.NomeProduto} é R${prod1.PrecoProduto}");
        }
    }
}