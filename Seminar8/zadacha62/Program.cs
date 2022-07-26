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
        int fill = 1;
        for(int l = array.GetLength(0)-2; l > 0 ; l--)
        {
            
            for(int h = array.GetLength(1)-2; h >= 0; h--)
            {
                   for(int j = 1; j < array.GetLength(0); j++)
                    {
                         for(int i = 0; i < array.GetLength(1); i++)
                        {                            
                            array[0,i] = i + 1;
                            
                        }               
                        array[j,array.GetLength(1)-1] = 4 + j;
                    }
                    array[array.GetLength(0)-1,h] = 7 - h;
            }
            array[l,0] = 10 - l;
        }

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