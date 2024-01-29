using System;

class Program
{
    static void Main()
    {
        // Задаем произвольную строку
        string inputString = "level";

        // Проверяем, является ли строка палиндромом
        bool isPalindrome = IsPalindrome(inputString);

        // Выводим результат
        if (isPalindrome)
        {
            Console.WriteLine("Строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом.");
        }
    }

    static bool IsPalindrome(string input)
    {
        // Приводим строку к нижнему регистру для учета регистронезависимости
        input = input.ToLower();

        // Получаем обратную строку
        string reversedString = ReverseString(input);

        // Сравниваем исходную строку с обратной
        return input == reversedString;
    }

    static string ReverseString(string input)
    {
        // Преобразуем строку в массив символов, обращаем массив и создаем новую строку
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

