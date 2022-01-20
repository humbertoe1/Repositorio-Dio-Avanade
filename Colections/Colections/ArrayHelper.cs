using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Colections
{
    class ArrayHelper
    {
        public void SortingBubbleSort (ref int[] array)
        {
            int tempo;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tempo = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tempo;
                    }

                }

            }
        }
        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        public void Sorting(ref int[] array)
        {
            Array.Sort(array);
        }

        public void Copying(ref int[] arrayOriginal, ref int[] arrayCopy)
        {
            Array.Copy(arrayOriginal, arrayCopy, arrayOriginal.Length);
        }

    }
}
