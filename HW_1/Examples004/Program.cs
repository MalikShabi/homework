// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Enter a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 0;
while (number2 < number1)
{
    number2++;
    if (number2 % 2 == 0)
    {
        Console.WriteLine(number2 + " ");
    }
}

