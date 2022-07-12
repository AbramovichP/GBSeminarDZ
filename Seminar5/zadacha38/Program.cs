// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] CreateRealRandomArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().Next(1,10) + new Random().NextDouble(),2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

double SearchMin(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
        if(array[i] < min) min = array[i];
    
    return min;
}

double SearchMax(double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
        if(array[i] > max) max = array[i];
    
    return max;
}

double[] arr = CreateRealRandomArray(5);
PrintArray(arr);
double result = (SearchMax(arr) - SearchMin(arr));
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна: " + result);
