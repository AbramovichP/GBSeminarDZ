// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = Math.Round((new Random().Next(minValue,maxValue + 1)) + new Random().NextDouble(),1);

    return newArray;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] my2dArray = Create2dArray(m, n, -9, 8);

PrintArray(my2dArray);
