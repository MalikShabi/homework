//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

ArrayRandom(numbers);
Console.Write("Array: ");
OutputArray(numbers);
int summ = 0;

for (int j = 0; j < numbers.Length; j += 2)

     summ += numbers[j];

Console.WriteLine($"Summ odd positions: {summ}");


void ArrayRandom(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}

void OutputArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}