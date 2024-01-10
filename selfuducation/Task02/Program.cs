int[] myArray = { 10, 5, 7, 6 };
int sum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0)
    {
        sum += myArray[i];
        Console.WriteLine(sum);
    }
}
