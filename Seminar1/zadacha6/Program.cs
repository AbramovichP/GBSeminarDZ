//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int number;

Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Число чётное.");
}
else
{
    Console.WriteLine("Число не чётное.");
}