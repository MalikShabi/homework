// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int calculate(int number)
{
    int temp = 0;
    int summ = 0;
    while (number > 0)
    {
        temp = number % 10;
        summ = summ + temp;
        number = number / 10;
    }
    return summ;
}
int allsumm = calculate(number);
Console.WriteLine($"Summ of all numbers: {allsumm}");