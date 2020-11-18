using System;

namespace funcao_while2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Exercício tabuada - while");

           Console.WriteLine("Qual tabuada você quer saber");
           int tabuada = int.Parse(Console.ReadLine());

           Console.WriteLine("Conheça a tabuada");
           int contador = 0;
           while (contador <= 10)
           {
               Console.WriteLine(tabuada * contador);

               contador = contador + 1;
           }
        }
    }
}
