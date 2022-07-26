// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SummElements(int m, int n)
{
    if(n == m) 
       return m;
    return SummElements(m,n-1) + n;
}
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна: {SummElements(m,n)}");