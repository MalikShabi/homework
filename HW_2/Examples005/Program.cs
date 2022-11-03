// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int figure = number / 10 % 10;
Console.WriteLine(figure);