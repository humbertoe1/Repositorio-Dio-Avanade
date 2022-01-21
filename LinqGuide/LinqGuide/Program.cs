using System;
using System.Linq;

namespace LinqGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayDeInteiros = new int[15] {100, 50, 25, 15, 1, 6, 20, 0, 5, 16, 1, 4, 8, 15, 19 };
            
            //como obter somete os valores pares da array, 2 métodos:
            var numerosPares =
                from num in arrayDeInteiros
                where num % 2 == 0
                orderby num
                select num;

            var numerosPares2 = arrayDeInteiros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            Console.WriteLine("Array original: " + string.Join(", ", arrayDeInteiros));
            Console.WriteLine("Numeros pares query: " + string.Join(", ", numerosPares));
            Console.WriteLine("Numeros pares por método: " + string.Join(", ", numerosPares2));

            var minimo = arrayDeInteiros.Min();
            var maximo = arrayDeInteiros.Max();
            var medio = arrayDeInteiros.Average();
            var soma = arrayDeInteiros.Sum();
            var semRepetir = arrayDeInteiros.Distinct();

            Console.WriteLine($"O valor minimo da array é {minimo}, a variavel maxima é {maximo}, o valor medio é {medio} ");
            Console.WriteLine($"A soma de todos os elementos é : {soma}");
            Console.WriteLine($"Array Sem repetição {string.Join(", ", semRepetir)}");


        }
    }
}
