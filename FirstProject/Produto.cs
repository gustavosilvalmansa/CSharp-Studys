using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        //PROPERTIES
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

   



        // Construtor principal
        public Produto(string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        // Sobrecarga: caso não informe quantidade, assume 0
        public Produto(string nome, double preco) : this(nome, preco, 0)
        {
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return $"{_nome}, $ {Preco.ToString("F2")}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2")}";
        }


    }
}
