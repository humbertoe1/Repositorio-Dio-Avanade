using System;
using System.Collections.Generic;

namespace Xenlongao
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = Convert.ToInt32(Console.ReadLine()); // C recebe os casos de teste

            List<int> listaResposta = new List<int>();
            
            while (C > 0)// o Loop vai rodar até não haver casos de teste
            {
                int N = Convert.ToInt32(Console.ReadLine()); // N vai receber o numero de esferas.

                int resposta = 0; //resposta começa com zero mesmo.
                int contadorDeDivisores = 1; //Para otimizar o código eu dividi o N por dois dentro do for, o motivo disso
                                             //é que não mais vai ser necessária testar os números que passam da metade do N. Por exemplo:
                                             //Caso N = 10, o for vai testar 1, 2, 3, 4 e 5. Mas não vai tester 6, 7, 8 e 9 que obviamente não são divisores de 10.
                                             //o contador é inciado em 1, pois deixamos de testar outra ocorrencia obvia, N/NW




                while (N > 0) // deixando N-- não daria certo, o valor que entraria dentro do while seria o N - 1. Por isso mudei o N-- de lugar
                {
                    for (int i = 1; i <= N / 2; i++)
                    {
                        if (N % i == 0)
                        {
                            contadorDeDivisores++;

                        }

                    }
                    /*Console.WriteLine($"O numero {N} tem {contadorDeDivisores} divisores");*/ // Apenas use essa parte do código se quiser fazer algum tipo de verificação
                    if (contadorDeDivisores % 2 == 0)
                        resposta++;

                    contadorDeDivisores = 1;
                    N--;
                }

                listaResposta.Add(resposta);
                C--;
            }
            foreach (var item in listaResposta)
            {
                Console.WriteLine($"{item}");
            }
            
        }
    }
}
