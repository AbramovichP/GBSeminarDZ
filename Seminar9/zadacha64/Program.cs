// Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
int DigitsNumber(int n)
{
    
    if(n / 10 > 0) 
    {
        return DigitsNumber(n/10) + 1;  
    }
    else return 1;
}

Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество цифр в числе: " + DigitsNumber(n));