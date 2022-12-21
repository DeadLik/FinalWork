int ArrayLength(string[] array)
{
    int lenghtArr = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) lenghtArr++;
    }

    return lenghtArr;
}