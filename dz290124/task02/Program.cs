using System;

class Program
{
    static void Main()
    {
        // Задаем строку с латинскими буквами в обоих регистрах
        string inputString = "Hello World";

        // Формируем строку, в которой все заглавные буквы заменены на строчные
        string resultString = ConvertToUpperToLower(inputString);

        // Выводим результат
        Console.WriteLine(resultString);
    }

    static string ConvertToUpperToLower(string input)
    {
        // Используем метод ToLower для замены всех заглавных букв на строчные
        return input.ToLower();
    }
}

