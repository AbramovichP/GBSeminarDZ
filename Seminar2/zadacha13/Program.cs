//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber(int n)
{
    if(n < 100)
        Console.WriteLine("Третьей цифры нет.");
    else
        if(n > 999)
            {
                while(n > 999)
                {
                    n = n / 10; 
                }
                int res = n % 10;
                Console.WriteLine("Третья цифра заданного числа: "+ res);
            
            }
        else
        {
            int res2 = n % 10;
            Console.WriteLine("Третья цифра заданного числа: "+ res2);    
        }
}

Console.Write("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)number = number * -1;

ThirdNumber(number);
