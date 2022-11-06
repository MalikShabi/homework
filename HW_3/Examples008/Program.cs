//Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int rev = 0;
int div = 0;
while (num > 0)
{
    div = num % 10;
    rev = rev * 10 + div;
    num = num / 10;
}
if (temp == rev)
{
    Console.WriteLine("It`s a palindrome!");
}
else
{
    Console.WriteLine("It`s not a palindrome");
}

