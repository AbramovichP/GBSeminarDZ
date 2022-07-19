// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void ValueOfElement(int[,] array, int rowsValue, int columnsValue)
{
    if(rowsValue >= array.GetLength(0) || columnsValue >= array.GetLength(1))
    {
        Console.WriteLine($"{rowsValue} {columnsValue} --> Такого числа нет в массиве.");
    }
    else
    {
        Console.WriteLine($"Значение элента: {array[rowsValue,columnsValue]}");
    }
}

Console.Write("Введите позицию в строке: ");
int myRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию в столбце: ");
int myColumns = Convert.ToInt32(Console.ReadLine());

int[,] my2dArray = Create2dArray(5,5,1,9);

Print2dArray(my2dArray);
Console.WriteLine();
ValueOfElement(my2dArray,myRows,myColumns);