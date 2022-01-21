using System;
using System.Collections.Generic;
namespace Dicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            //att para nao duplicar!!
            estados.Add("SP", "São Paulo");
            estados.Add("PB", "Paraíba");
            estados.Add("PE", "PernambucoCom erro de digitação!!!!!!!");
            estados.Add("UT", "Utah"); //alguem colocou um estado de outro país, depois vai ser removido!
            
            //imprimindo todos os estados com suas chaves:
            foreach(KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
            }
            //buscando um valor no dictionary
            string estadoProcurado = "PE";
            Console.WriteLine("Valor Original: ");
            Console.WriteLine(estados[estadoProcurado]);


            //adicionando valor:
            Console.WriteLine("Valor Alterado: ");
            estados[estadoProcurado] = "Pernambuco";
            Console.WriteLine(estados[estadoProcurado]);
            Console.WriteLine("Hello World!");

            //removendo valor:
            estadoProcurado = "UT";
            estados.Remove(estadoProcurado);

            //imprimindo todos os valores, agora atualizados
            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
            }

            //ao acessar uma chave que não esta presente, a execução do codigo vai parar
            //var teste = estados["UT"]

            if(estados.TryGetValue(estadoProcurado, out string estadoEncontrado))
            {
                Console.WriteLine(estadoEncontrado);

            }
            else
            {
                Console.WriteLine($"Chave {estadoProcurado} não existe mais no programa ou foi removida!");
            }

        }
    }
}
