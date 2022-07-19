// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

void Print2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void ArithmeticMeanInTheColumn(int[,] array)
{
    double sum = 0;
    int volum = array.GetLength(0);
    for(int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j]; 
            
        }
        sum = sum / volum;
        Console.Write(sum + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] my2dArray = Create2dArray(m,n,1,9);
Print2dArray(my2dArray);
Console.Write("Среднее арифметическое каждого столбца: ");
ArithmeticMeanInTheColumn(my2dArray);
