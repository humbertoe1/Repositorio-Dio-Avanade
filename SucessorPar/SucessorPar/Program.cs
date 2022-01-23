using System;

namespace SucessorPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());

            if (X % 2 == 0)
                X+=2;
            else
                X++;

            Console.WriteLine($"{X}");
        }
    }
}
