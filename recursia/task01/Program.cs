int sum(int numbers)
{
    if (numbers == 0)
        return 0;
    return sum(numbers / 10) + numbers % 10;
}
Console.WriteLine(sum(123));

