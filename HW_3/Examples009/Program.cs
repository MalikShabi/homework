//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count < number)
{
    count++;
    Console.WriteLine(Math.Pow(count, 3));
    
}