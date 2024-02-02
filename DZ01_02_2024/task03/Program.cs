
using System;

class Program
{
    static void Main()
    {
        // Произвольный массив
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write($"{arr[index]} ");
            PrintArrayReversed(arr, index - 1);
        }
    }
}
