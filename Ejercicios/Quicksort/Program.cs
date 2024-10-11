using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 34, 7, 23, 32, 5, 62, 32, 7 };
            Console.WriteLine("Array antes de ordenar:");
            PrintArray(array);

            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Array después de ordenar:");
            PrintArray(array);

            Console.ReadLine();
        }

        // Método QuickSort
        static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right); // Particiona el arreglo
                QuickSort(array, left, pivotIndex - 1);  // Aplica QuickSort a la sublista izquierda
                QuickSort(array, pivotIndex + 1, right); // Aplica QuickSort a la sublista derecha
            }
        }

        // Método para particionar el arreglo
        static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];  // Selecciona el último elemento como pivote
            int i = left - 1;  // Índice para los elementos menores que el pivote

            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);  // Intercambia elementos si son menores que el pivote
                }
            }

            Swap(array, i + 1, right);  // Coloca el pivote en su posición correcta
            return i + 1;  // Devuelve la posición del pivote
        }

        // Método para intercambiar dos elementos en el arreglo
        static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        // Método para imprimir el arreglo
        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
