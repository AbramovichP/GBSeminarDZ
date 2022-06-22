// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int number_first, number_second;

Console.Write("Введите первое число: ");
number_first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
number_second = Convert.ToInt32(Console.ReadLine());

if(number_first == number_second) Console.WriteLine("Числа равны.");

if(number_first > number_second)
{
    Console.Write(number_first + " число большее, а ");
    Console.WriteLine(number_second + " число меньшее.");
}

if(number_second > number_first)
{
    Console.Write(number_second + " число большее, а ");
    Console.WriteLine(number_first + " число меньшее.");
}