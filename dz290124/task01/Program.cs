using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив символов
        char[,] charArray = {
            { 'H', 'e', 'l', 'l', 'o' },
            { 'W', 'o', 'r', 'l', 'd' }
        };

        // Создаем строку из символов массива
        string result = GetStringFromCharArray(charArray);

        // Выводим результат
        Console.WriteLine(result);
    }

    static string GetStringFromCharArray(char[,] charArray)
    {
        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);

        // Используем StringBuilder для эффективной конкатенации символов
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sb.Append(charArray[i, j]);
            }
        }

        return sb.ToString();
    }
}

