int ArrayLength(string[] array)
{
    int lenghtArr = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) lenghtArr++;
    }

    return lenghtArr;
}

void WordBusting(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}