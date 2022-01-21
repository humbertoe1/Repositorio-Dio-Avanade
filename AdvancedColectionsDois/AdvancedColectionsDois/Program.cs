using System;
using System.Collections.Generic;

namespace AdvancedColectionsDois
{
    class Program
    {
        static void Main(string[] args)
        {
            //A pilha obedece a regra LIFO, o último a entrar é o primeiro a sair
            Stack<string> pilhaLivros = new Stack<string>();

            //push insere objeto no topo || pop remove objetos || count retorna o tamanho da fila

            
            pilhaLivros.Push("O senhor dos anéis: O Retorno do Rei");
            pilhaLivros.Push("O senhor dos anéis: A Sociedade do Anel");
            pilhaLivros.Push("O senhor dos anéis: As Duas Torres");

            Console.WriteLine($"Quantos livros que faltam ler: {pilhaLivros.Count}");
            while (pilhaLivros.Count > 0)
            {
                Console.WriteLine($"Próximo Livro para leitura é: {pilhaLivros.Peek()}");
                Console.WriteLine($"{pilhaLivros.Pop()} foi lido com sucesso!");
            }

            Console.WriteLine($"Quantos livros que faltam ler: {pilhaLivros.Count}");
        }
    }
}
