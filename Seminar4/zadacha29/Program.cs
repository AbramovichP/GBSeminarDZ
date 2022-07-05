// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($" [{array[i]}]");
    }
    Console.WriteLine();
}

int[] arr = new int[8];

FillArray(arr);
PrintArray(arr);