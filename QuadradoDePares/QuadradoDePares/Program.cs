using System;

namespace QuadradoDePares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i <= n; i += 2)
            {
                if(i == 0)
                {
                    continue;
                }
                
                int b = i * i;
                Console.WriteLine($"{i}^2 = {b}");
            }

        }
    }
}
