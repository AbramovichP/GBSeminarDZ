// Заполните спирально массива

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
            int n = array.GetLength(0);
            int m = array.GetLength(1);
            int row = 0;
            int column = 0;
            int x = 1;
            int y = 0;
            int dirChanges = 0;
            int visits = m;
 
            for (int i = 0; i < array.Length; i++) 
            {
                array[row, column] = i + 1;
                
              if (--visits == 0) 
              {
                visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                int temp = x;
                x = -y;
                y = temp;
                dirChanges++;
              }
              column += x;
              row += y;
            }
            return array;

}

Console.Write("Введите количество строк в массиве: ");
int myRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int myColumns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(myRows,myColumns);
int[,] fillerMyArray = SpiralFilling2dArray(myArray);
Print2dArray(fillerMyArray);