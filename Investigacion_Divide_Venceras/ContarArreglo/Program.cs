namespace ContarArreglo
{
    internal class Program
    {
        static int Count(int[] arr, int index)
        {
            if (index == arr.Length)
                return 0;

            return 1 + Count(arr, index + 1);
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int count = Count(arr, 0);
            Console.WriteLine("El numero de elementos en el arreglo es: " + count);
            Console.ReadKey();
        }
    }
}
