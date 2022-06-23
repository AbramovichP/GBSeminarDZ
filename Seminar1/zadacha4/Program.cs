// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int numberA, numberB, numberC,  max;

Console.WriteLine("Введите первое из трех чисел: ");
numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе из трех чисел: ");
numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
numberC = Convert.ToInt32(Console.ReadLine());

max = numberA;

if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.WriteLine(max + " это максимальное число из введеных вами трех чисел.");