// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreatRandomArray(int size)
{
    int[] array = new int[size];
    for(int i =0; i < size; i++)
        array[i] = new Random().Next(100,1000);
    return array;
}

int SumOfEvenNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length;i++)
        if(array[i] % 2 == 0) count++;
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine("]");
}

Console.Write("Введите количество чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = CreatRandomArray(n);
PrintArray(arr);
Console.WriteLine($"Количество чётных числе в массиве = {SumOfEvenNum(arr)}");
