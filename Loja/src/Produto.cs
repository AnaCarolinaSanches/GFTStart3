using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.src
{
    public class Produto
    {
        public int Qtd { get; set; }
        public double Preco { get; set; }
        public String Nome { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int qtd)
        {
            this.Qtd = qtd;
            this.Preco = preco;
            this.Nome = nome;
        }
    }
}
