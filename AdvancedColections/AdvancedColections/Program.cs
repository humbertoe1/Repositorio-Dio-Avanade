using System;
using System.Collections.Generic;

namespace AdvancedColections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Como implementar uma fila em C#?
            //Esse é o comportamento de uma fila First in First Out, O elemento mais antigo da fila sempre será o primeiro a sair.
            Queue<string> filaDoBanco = new Queue<string>();
            int chegou;
            string nome;
            int contador = 0;

            filaDoBanco.Enqueue("Pedro");
            filaDoBanco.Enqueue("João");
            filaDoBanco.Enqueue("Lucas");



            while (filaDoBanco.Count > 0)
            {
                Console.WriteLine("Alguem chegou ao banco? Responda 1 para sim e 2 para não...");
                chegou = Convert.ToInt32(Console.ReadLine());

                if (chegou == 1)
                {
                    Console.WriteLine("Digite o nome do cliente: ");
                    nome = Console.ReadLine();
                    filaDoBanco.Enqueue(nome);
                }
                
                if(contador > 3)
                {
                    Console.WriteLine($"Proximo! Pode vir: {filaDoBanco.Peek()}");
                    filaDoBanco.Dequeue();
                    contador = 0;
                    continue;
                }
                Console.WriteLine($"Pessoas na fila: {filaDoBanco.Count}");
                contador++;
            }
            Console.WriteLine("Fila acabou!");
        }
    }
}
