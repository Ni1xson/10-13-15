int[] GenerateArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
        Console.Write($"{arr[i]} ");

    }

    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write($"-->");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}]");
    }
}

int[] array = GenerateArray();
PrintArray(array);
