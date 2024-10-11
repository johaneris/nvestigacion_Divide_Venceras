using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaElementosArreglo
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = Sum(arr, 0, arr.Length - 1);
            Console.WriteLine("La suma del arreglo es: " + sum);
            Console.ReadKey();
        }

        static int Sum(int[] arr, int low, int high)
        {
            // Si solo hay un elemento en el arreglo
            if (low == high)
                return arr[low];

            
            int mid = (low + high) / 2;
            return Sum(arr, low, mid) + Sum(arr, mid + 1, high); //Recursividad
        }

    }
}
