//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());


void NaturalToLowNum (int number)
{
    if (number < 0) Console.Write($"{number} not natural number");
    if (number == 0) return;
    Console.Write(number + " ");
    NaturalToLowNum (number - 1);
}

NaturalToLowNum(number);