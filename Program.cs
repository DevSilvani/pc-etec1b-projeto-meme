using System;

namespace pc_etec1b_projeto_meme
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            Console.Write("digite o que você acha sobre este programa: ");
            frase = Console.ReadLine();
            Console.Clear();
            frase = frase.Substring(0,10);
            Console.WriteLine(frase+"... NÃO, PERA.\nTô nervoso");
            Console.ReadKey();
        }
    }
}
