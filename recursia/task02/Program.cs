//// 3. Считать строку с консоли, содержащую латинские буквы.
//    Вывести на экран согласные буквы этой строки.
//    
//    Использовать рекурсию. Не использовать цикл


void str(string result, int index = 0)
{
    if (result.Length == index) return;

    string vowels = "bcdfghjklmnpqrstvwxz";
    if (vowels.Contains(char.ToLower(result[index])))
    {
        Console.Write(result[index]);
    }
    str(result, index + 1);
}


str("Hello world");