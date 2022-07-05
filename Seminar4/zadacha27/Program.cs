// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SummNumber(int n)
{
    int sum = 0;
    int remains = 0;
    while(n > 0)
    {
        remains = n % 10;
        sum = sum + remains;
        n = n / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SummNumber(number);
Console.WriteLine($"Результат суммы цифр в числе: {number}, равен: {result}");