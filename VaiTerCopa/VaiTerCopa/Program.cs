using System;

namespace VaiTerCopa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroDeReclamacoes;
            
            while((numeroDeReclamacoes = Console.ReadLine()) != null)
            {
                if (numeroDeReclamacoes == "0")
                {
                    Console.WriteLine("vai ter copa!");
                }
                else
                {
                    Console.WriteLine("vai ter duas!");
                }
            }
        }
    }
}
