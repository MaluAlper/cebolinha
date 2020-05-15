using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UMA MENSAGEM");
            string textodigitado = Console.ReadLine(); 
            
            Console.WriteLine("COMO O CEBOLINHA FALARIA:");
            string Cebolinha = textodigitado.Replace("r", "l");
            Console.WriteLine(Cebolinha);
            Console.ReadLine();


        }
    }
}