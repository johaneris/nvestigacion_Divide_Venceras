using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    internal class Program
    {
        static int BinarySearch(int[] arr, int target, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }

            int mid = (low + high) / 2;
            int midValue = arr[mid];

            if (midValue == target)
            {
                return mid;
            }
            else if (midValue < target)
            {
                low = mid + 1;
            }
            else {
                high = mid - 1;
            }
            return BinarySearch(arr, target, low, high);
        }

        static void Main()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int target = 10;
            int result = BinarySearch(arr, target, 0, arr.Length - 1);
            Console.WriteLine($"Elemento encontrado en la posicion: {result}");
            Console.ReadKey();
        }
    }
}