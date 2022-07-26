// Заполните спирально массив

int[,] Create2dArray(int rows, int columns)
{
    int[,] newarray = new int[rows,columns];

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

int[,] SpiralFilling2dArray(int[,] array)
{
    int count = array.GetLength(0) * array.GetLength(1);
   
    Console.WriteLine(count);
    for(int k = 0; k < count; k++)
    {   
       
        

    }
    return array;
}
Console.Write("Введите количество строк в массиве: ");
int myRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int myColumns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(myRows,myColumns);
Print2dArray(myArray);
int[,] fillerMyArray = SpiralFilling2dArray(myArray);
Print2dArray(fillerMyArray);