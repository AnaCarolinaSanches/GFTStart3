using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.src
{
    public class Loja
    {
        public String Nome { get; set; }
        public String CNPJ { get; set; }
        public List<Livro> Livros { get; set; }
        public List<VideoGame> VideoGames { get; set; }

        public Loja()
        {

        }

        public Loja(String nome, String cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            this.Nome = nome;
            this.CNPJ = cnpj;
            this.Livros = livros;
            this.VideoGames = videoGames;
        }

        public void Listalivros()
        {
            var qtdLivros = Livros.Count;

            if (qtdLivros > 0)
            {
                for (int i = 0; i < qtdLivros - 1; i++)
                {
                    Console.WriteLine("Titulo: " + Livros[i].Nome);
                    Console.WriteLine(" Preço: " + Livros[i].Preco);
                    Console.WriteLine(" Quantidade: " + Livros[i].Qtd);
                }
            }
            else
            {
                Console.WriteLine("A loja não tem livros no seu estoque.");
            }
        }
    }
}
