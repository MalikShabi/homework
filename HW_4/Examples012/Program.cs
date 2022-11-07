// Напишите программу, которая задаёт массив из N элементов
// и выводит их на экран.
Console.WriteLine("Enter a number: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
Console.WriteLine("Massif: ");
for (int i = 0; i < count + 1; i++)
{
    array[i] = new Random().Next(count + 1);
    Console.WriteLine($"{array[i]}; ");
}