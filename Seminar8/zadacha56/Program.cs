//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newarray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newarray[i,j] = new Random().Next(minValue,maxValue + 1);
    
    return newarray;
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

int[] SumElementsRows(int[,] array)
{
    int [] arraySum = new int[array.GetLength(0)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        arraySum[i] = sum;
    }
    return arraySum;
}

int MinIndexElementArray(int[] array)
{
    int min = array[0];
    int index = 1;
    for(int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
            index = i + 1;
        }
        
    }
    return index;
}

Console.Write("Введите количество строк в массиве: ");
int myRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int myColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray2d = Create2dArray(myRows,myColumns,min,max);
Print2dArray(myArray2d);
int[] myArray = SumElementsRows(myArray2d);
Console.WriteLine();
int result = MinIndexElementArray(myArray);
Console.WriteLine(result + " строка с наименьшей суммой элементов");