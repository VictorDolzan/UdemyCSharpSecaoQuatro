using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuatro
{
    class Produto
    {
        private string _nomeProduto;
        private double _precoProduto;
        private int _quantidadeProduto;

        //private double _quantidadeTotal;
        public string NomeProduto
        {
            get
            {
                return _nomeProduto;
            }
            set
            {
                _nomeProduto = value;
            }
        }
        public double PrecoProduto
        {
            get
            {
                return _precoProduto;
            }
            set
            {
                _precoProduto = value;
            }
        }
        public void AdicionarProdutos(int quantidadeExterna)
        {
            _quantidadeProduto += quantidadeExterna;
        }
        public void RemoverProdutos(int quantidadeExterna)
        {
            if (quantidadeExterna > _quantidadeProduto)
            {
                Console.WriteLine("Valor Inválido!");
                return;
            }
            else
            {
                _quantidadeProduto -= quantidadeExterna;
            }
        }
        public double ValorTotalEmEstoque()
        {
            return _quantidadeProduto;
        }

    }
}