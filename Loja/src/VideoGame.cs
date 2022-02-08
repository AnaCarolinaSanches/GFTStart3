using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.src
{
    public class VideoGame : Produto, Imposto
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }

        public bool isUsado { get; set; }

        public VideoGame()
        {

        }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool usado) : base(
            nome, preco, qtd)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.isUsado = usado;
        }

        public double CalculaImposto()
        {
            if (this.isUsado)
                return this.Preco * 0.25;
            else
                return this.Preco * 0.45;
        }
    }
}
