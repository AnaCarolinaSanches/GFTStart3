using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.src
{
    public class Livro : Produto, Imposto
    {
        public string Autor { get; set; }
        public String Tema { get; set; }
        public int qtdPag { get; set; }

        public Livro()
        {

        }

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(
            nome, preco, qtd)
        {
            this.Autor = autor;
            this.Tema = tema;
            this.qtdPag = qtdPag;
        }

        public double CalculaImposto()
        {
            if (this.Tema.ToLower() == "educativo")
                return 0;
            else
                return this.Preco * 0.1;
        }
    }
}
