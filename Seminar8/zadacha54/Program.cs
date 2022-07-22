// Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue,maxValue +1);

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

int[,] SortRows2dArray(int[,] array)
{   
    for(int k = 0; k < array.GetLength(1); k++)
        for(int i = 0; i < array.GetLength(0); i++)
            for(int j = 0; j < array.GetLength(1)-1; j++)
                {
                    int temp = array[i,j];

                    if(temp > array[i,j+1])
                    {
                    temp = array[i,j+1];
                    array[i,j+1] = array[i,j];
                    array[i,j] = temp;
                    }

                }

    return array;
}

Console.Write("Введите количество строк в массиве: ");
int myRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int myColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(myRows, myColumns, min, max);
Print2dArray(myArray);
Console.WriteLine();
SortRows2dArray(myArray);
Print2dArray(myArray);