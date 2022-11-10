//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Enter array size:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayRandom(numbers);
Console.Write("Array: ");
OutputArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"Even numbers: {count}");

void ArrayRandom(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,999);
    }
}
void OutputArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }

    Console.WriteLine();
}
