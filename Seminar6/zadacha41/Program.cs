//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] RequestForNumbers(int M)
{
    int[] array = new int[M];

    for(int i = 0; i < M; i++)
    {
        Console.Write("Введите число № "+(i+1)+": ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int NumbersGreaterThanZero(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) count++;
    
    return count;
}

Console.Write("Какое количество чисел вы хотите ввести? : ");
int volume = Convert.ToInt32(Console.ReadLine());
if(volume > 0)
{
    int[] hisArray = RequestForNumbers(volume);
    Console.WriteLine("Количество введеных чисел больше нуля = " + NumbersGreaterThanZero(hisArray));
}
else Console.WriteLine("Число должно быть больше нуля!");