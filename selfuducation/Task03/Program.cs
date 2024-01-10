int[] myArray = { 10, 5, 7, 6 };
int lowest = myArray[0];
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] < lowest)
    {
        lowest = myArray[i];
        Console.WriteLine(lowest);
    }

}

