///Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Inter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inter the third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

    if (num1 > num2)
    {
        max = num1;
    }
    else
    {
        max = num2;
    }
    if (max < num3)
    {
        max = num3;
    }
    Console.WriteLine("Maximum number: " + max);