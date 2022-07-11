// Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreatRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i =0; i < size; i++)
        array[i] = new Random().Next(min, max+1);
    return array;
}

int SumOfElements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(i % 2 != 0) sum = sum + array[i];
    return sum;
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

Console.Write("Введите минимальное число массива: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число массива: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] arr = CreatRandomArray(n, a, b);
PrintArray(arr);
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях = {SumOfElements(arr)}");
