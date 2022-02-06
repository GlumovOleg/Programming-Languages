int[] arr = { 1, 7, 6, 5, 4, 8, 2, 3, 8, 1, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;


    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temprary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temprary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);