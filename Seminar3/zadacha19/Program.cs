// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Palindrome(int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    int num5 = num % 10;

    if(num1 == num5 && num2 == num4)
        Console.WriteLine("Число является палиндромом!");
    else
        Console.WriteLine("Число не палиндром.");

}

Console.Write("Введите пятизначное число: " );
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99999 || number < 10000)
    Console.WriteLine("Введено не пятизначное число.");
else
    Palindrome(number);
