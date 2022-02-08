using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listPessoas = new List<Pessoa>();
            Pessoa pessoa_1 = new Pessoa();
            pessoa_1.Nome = "João";
            pessoa_1.Idade = 15;

            Pessoa pessoa_2 = new Pessoa();
            pessoa_2.Nome = "Leandro";
            pessoa_2.Idade = 21;

            Pessoa pessoa_3 = new Pessoa();
            pessoa_3.Nome = "Paulo";
            pessoa_3.Idade = 17;

            Pessoa pessoa_4 = new Pessoa();
            pessoa_4.Nome = "Jéssica";
            pessoa_4.Idade = 18;

            listPessoas.Add(pessoa_1);
            listPessoas.Add(pessoa_2);
            listPessoas.Add(pessoa_3);
            listPessoas.Add(pessoa_4);


            var oldPerson = listPessoas.OrderByDescending(p => p.Idade).FirstOrDefault();
            Console.WriteLine(oldPerson.Nome);


            foreach (var item in listPessoas)
            {
                Console.WriteLine(item.Nome + " " + item.Idade);
            }

            int qtdBefore = listPessoas.Count;
            List<Pessoa> pessoasToRemove = new List<Pessoa>();

            for (int i = 0; i < qtdBefore; i++)
            {
                if (listPessoas[i].Idade < 18)
                    pessoasToRemove.Add(listPessoas[i]);
            }

            foreach (var item in pessoasToRemove)
            {
                listPessoas.Remove(item);
            }

            int qtdAfter = listPessoas.Count;

            Console.WriteLine("Quantidade antes: " + qtdBefore);
            Console.WriteLine("Quantidade depois: " + qtdAfter);


            if (listPessoas.Any(p => p.Nome == "Jéssica"))
                Console.WriteLine("Jéssica esta na lista ");
            else
                Console.WriteLine("Jéssica Não esta na lista ");

            Console.ReadLine();
        }

    }
}
