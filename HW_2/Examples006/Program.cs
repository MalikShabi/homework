// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = 0;
if (number >= 100)
{
    while (number > 999)
    {
        number /= 10;
    }
    digit = number % 10;
    Console.WriteLine(digit);
}
else
{
    Console.WriteLine("There is no third digit: ");
}