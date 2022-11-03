// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Enter the day number of the week: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 7)
{
    Console.WriteLine("There is no such day in a week!");
}
else if (day == 5 || day == 6)
    {
    Console.WriteLine("Weekend!!!");
    }
else
    {
    Console.WriteLine("To work!");
    }