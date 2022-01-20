using System;

namespace Colections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arrayInteiros = new int[3]; // This is a simple Array

            arrayInteiros[0] = 1;
            arrayInteiros[1] = 2;
            arrayInteiros[2] = 3; 
            
            for (int i = 0; i < arrayInteiros.Length; i++) // This for statement will run through the size of the array checking all elements
            {
                Console.WriteLine("Na posição: " + i + " temos o valor "+ arrayInteiros[i]);
            }

            foreach (int i in arrayInteiros) //This foreach statement will run through all integers it can find inside the array.
            {
                Console.WriteLine(" temos o valor " + i);
            }
            //Initializating the array withy it's values
            int[,] arrayMulti = new int[4, 3]
                {
                    { 8, 3, 4 },
                    { 1, 0, 2 },
                    { 3, 6, 7 },
                    { 15, 20, 200 }

                };
            // This is a multidimensional Array, more precisily it looks like this:
            /*
            |0,0|0,1|0,2|
            |1,0|1,1|2,2|
            |2,0|2,1|2,2|
            |3,0|3,1|3,2|



            | 8 | 3 | 4 |
            | 1 | 0 | 2 |
            | 3 | 6 | 7 |
            | 15| 20|200|
             */

            for (int i = 0; i < arrayMulti.GetLength(0); i++)
            {
                for (int j = 0; j < arrayMulti.GetLength(1); j++)
                {
                    Console.WriteLine("At the line " + i + " and column " + j + " we have the element: " + arrayMulti[i, j]);
                }

            }

           
        }
    }
}
