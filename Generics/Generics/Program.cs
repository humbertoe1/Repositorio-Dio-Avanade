using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesLista opLista = new OperacoesLista();

            List<string> estadosBR = new List<string>();
            string[] estadosNovos = new string[3] { "SC", "MT", "PB" };
            estadosBR.Add("SP");
            estadosBR.Add("MG");
            estadosBR.Add("BA");

            Console.WriteLine($"Quantidade de elementos na lista: {estadosBR.Count}");

            
            opLista.ImprimirListaString(estadosBR);
            //Removendo um elemento:
            estadosBR.Remove("MG");


            Console.WriteLine("Tentando Remover Elemento");
            opLista.ImprimirListaString(estadosBR);


            estadosBR.AddRange(estadosNovos);
            Console.WriteLine("Adicionando Elementos novos no final da lista");

            opLista.ImprimirListaString(estadosBR);

            estadosBR.Insert(2, "RJ");
            Console.WriteLine("Adicionando Elemento a lista no indice 2");
            opLista.ImprimirListaString(estadosBR);



        }
    }
}
