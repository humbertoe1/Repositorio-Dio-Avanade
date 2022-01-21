using System;

namespace SequenciaS
{
    class Program
    {
        static void Main(string[] args)
        {
            double operador, S = 1; // O operador servirá para calcular 1 dividido pelo contador i. "S" é a variavel pedida na questão
            for (double i = 1; i < 101; i++) // Dessa maneira, o loop do for vai acontecer até i chegar a 100, e depois será encerrado.
            {
                operador = 1/i;
                S += operador;
            }
            var resposta = Math.Round(S, 2); // o método aqui utilizado vai arredondar o valor de S para duas casas decimais e passar esse valor para "resposta"
            Console.WriteLine($"{resposta}");// A resposta vai ser impresssa aqui.
        }
    }
}
