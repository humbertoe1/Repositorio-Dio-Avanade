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
            //BubbleSort Example:

            ArrayHelper op = new ArrayHelper();
            int[] arrayForSorting = new int[10] { 5, 6, 11, 1, 3, 4, 7, 2, 10, 9 };
            Console.WriteLine("Original Array: ");
            op.PrintArray(arrayForSorting);

            //op.SortingBubbleSort(ref arrayForSorting);
            op.Sorting(ref arrayForSorting);

            Console.WriteLine("Array after Bubble Sorting: ");
            op.PrintArray(arrayForSorting);


            //Copying an array:


            int[] arrayCopy = new int[10];
            Console.WriteLine("arrayCopy antes de copiar: ");
            op.PrintArray(arrayCopy);

            op.Copying(ref arrayForSorting, ref arrayCopy);
            Console.WriteLine("arrayCopy depois de copiar: ");
            op.PrintArray(arrayCopy);

            //It checks if an element Exists on the Array:
            bool existe = op.ElementIsValid(arrayCopy, 10);
            if(existe)
                Console.WriteLine("this element is on the array");
            else
                Console.WriteLine("Not on the array");

            //It checks if an element Exists on the Array:
            existe = op.ElementIsValid(arrayCopy, 15);
            if (existe)
                Console.WriteLine("this element is on the array");
            else
                Console.WriteLine("Not on the array");

            Console.WriteLine("Checking if there are only elements greater than Zero on the Array: ");
            int value = 0;
            bool greaterThan = op.ElementsAreGreaterThan(arrayCopy, value);

            if(greaterThan)
                Console.WriteLine("All elements are greater than "+ value);
            else
                Console.WriteLine("There are elements less than or equal to " + value);

            Console.WriteLine("Checking if there are only elements greater than Five on the Array: ");
            value = 5;
            greaterThan = op.ElementsAreGreaterThan(arrayCopy, value);

            if (greaterThan)
                Console.WriteLine("All elements are greater than " + value);
            else
                Console.WriteLine("There are elements less than or equal to " + value);

            //Checking if there is an element on the Array
            value = 9;
            int foundValue = op.GetElement(arrayCopy, value);
            if (foundValue > 0) //Greater than zero because there no negative array index!
                Console.WriteLine("Value found on the Array");
            else
                Console.WriteLine("Value not found!");

            value = 100;
            foundValue = op.GetElement(arrayCopy, value);
            if (foundValue > 0) //Greater than zero because there no negative array index!
                Console.WriteLine("Value found on the Array");
            else
                Console.WriteLine("Value not found!");

            value = 7;
            int indexValue = op.GetIndexOfArray(arrayCopy, value);
            if(indexValue > -1)
                Console.WriteLine("the element {0} index is {1}", value, indexValue);
            else
                Console.WriteLine("value not foun on array!");

            value = 100;
            indexValue = op.GetIndexOfArray(arrayCopy, value);
            if (indexValue > -1)
                Console.WriteLine("the element {0} index is {1}", value, indexValue);
            else
                Console.WriteLine("value not found on array!");


            Console.WriteLine($"Array actual size is {arrayCopy.Length}");

            op.ChangeSizeOfArray(ref arrayCopy, arrayCopy.Length * 2);

            Console.WriteLine($"Array actual size is {arrayCopy.Length}");

            string[] arrayString = op.ArrayIntToString(arrayCopy);
            Console.WriteLine(arrayString[0]);

        }
    }
}
