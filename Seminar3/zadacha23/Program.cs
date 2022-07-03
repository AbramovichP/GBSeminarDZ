// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void TableOfCubes(int N)
{
    int i = 1;

    while(i <= N)
    {
        Console.Write(i*i*i + " ");
        i++;
    }
    Console.WriteLine();
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

TableOfCubes(num);

