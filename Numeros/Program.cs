using System;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Digite um numero: ");
            int NumeroDigitado = int.Parse(Console.ReadLine());
            int maior = NumeroDigitado;
            int menor = NumeroDigitado;
            int somatorio = 0;
            

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Digite outro numero: ");
                NumeroDigitado = int.Parse(Console.ReadLine());

                if (NumeroDigitado < menor)
                {
                    menor = NumeroDigitado;
                }
                if (NumeroDigitado > menor)
                {
                    maior = NumeroDigitado;
                }
                somatorio += NumeroDigitado; 
            }
            int media = somatorio / 5;
            Console.WriteLine("meida é: " + media);
            Console.WriteLine("\nO numero Maior Digitado foi:" + maior + "\n O numero Menor Digitado foi" + menor);

            Console.ReadLine();
        }
    }
}
