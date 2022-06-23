// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N, counter = 1;

Console.WriteLine("Напишите число, а я покажу все чётные числа от 1 до этого числа: ");
N = Convert.ToInt32(Console.ReadLine());

while(N >= counter )
{
    if(counter % 2 == 0)
    {
        Console.Write(counter + ", ");
    }
    counter++;
}

