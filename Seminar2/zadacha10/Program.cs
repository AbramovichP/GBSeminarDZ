//Напишите программу, которая принимает на вход трёхзначное число и на входе показывает цифру этого числа.
int SecondNum(int num)
{
    int des = num / 10;
    int ed = des % 10;
    return ed;
}

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondNum(number);
Console.WriteLine("Вторая цифра введенного числа равна: "+result);