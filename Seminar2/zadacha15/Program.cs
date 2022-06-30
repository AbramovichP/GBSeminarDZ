// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void WeekendDay(int day)
{
    if(day == 7 ^ day == 6)
        Console.WriteLine("Выходной день!");
    else
        Console.WriteLine("День не является выходным.");
}

Console.Write("Введите цифру обзначающую день недели от 1 до 7 : ");
int num = Convert.ToInt16(Console.ReadLine());

if(num <= 0 ^ num > 7)
    Console.WriteLine("Эта цифра не обозначает день недели");
else
    WeekendDay(num);

