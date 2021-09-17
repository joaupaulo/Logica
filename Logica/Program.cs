using System;
using System.Linq;

namespace Logica
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Numeros = { 6, 9, 15, -2, 92, 11 };
            int  Maiornumero = 0;
            int MenorNumero = 0;
            double Soma = 0;
            double MediaNumeros = 0;
      

            for ( int i = 1;  i < Numeros.Length; i++)
            {
             
                if(Numeros[i] > Numeros[Maiornumero])
                {
                    Maiornumero = i;
                }

                else if (Numeros[i] < Numeros[MenorNumero])
                {
                    MenorNumero = i;
                }

 
            }


            for( int i = 0; i < Numeros.Length; i++)
            {


                Soma = Soma + Numeros[i];

                MediaNumeros = Soma / Numeros.Length;

            }


            //Outra forma de encontrar o maior e o menor numero de uma array
            Numeros.Max();
            Numeros.Min();
            //Outra forma de encontrar a media da array
            var Media = (Numeros.Sum() / Numeros.Length);

           

            Console.WriteLine("Construa um algoritmo que seja capaz de ler uma sequência de números inteiros e responder às seguintes perguntas:");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("A) Qual o número de maior valor?");
            Console.WriteLine(Numeros[Maiornumero]);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("B) Qual o número de menor valor?");
            Console.WriteLine(Numeros[MenorNumero]);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("C) Quantos números contém a sequência?");
            Console.WriteLine(Numeros.Length);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("D) Qual a média de todos os números?");
            Console.WriteLine(Math.Round(MediaNumeros,2));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }



     

    }
}
