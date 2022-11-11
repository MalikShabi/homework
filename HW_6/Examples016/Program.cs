//Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Enter numbers by a space: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = array.Count(x => x > 0);
Console.WriteLine($"Number of elements > 0: {count}");