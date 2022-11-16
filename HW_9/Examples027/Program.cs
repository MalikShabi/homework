//Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int numberM, numberN;
InputNumbers(out numberM, out numberN);

void GapNumberSum(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Summ natural elements in intervals from M to N: {sum}");
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);

void InputNumbers(out int numberM, out int numberN)
{
    Console.Write("Enter number M: ");
    numberM = int.Parse(Console.ReadLine());
    Console.Write("Enter number N: ");
    numberN = int.Parse(Console.ReadLine());
}