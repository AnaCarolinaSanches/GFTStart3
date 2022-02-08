using System;

namespace DiasVivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string DataNascimentoVinicius = "Vinicius 14 02 92";
            
            var vetDtNasc = DataNascimentoVinicius.Split("Vinicius 14 02 92 ");
            string [] DiasVividos = DataNascimentoVinicius.Split(' ');
           

            //Console.WriteLine(string.Format("{0}", DiasVividos[0]);
            Console.WriteLine(DiasVividos[3] + "dias");
        }
    }
}
