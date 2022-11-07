// Напишите метод, который принимает на вход два числа (A и B)
// и возводит число A в целую степень B.
Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number: ");
int degree = Convert.ToInt32(Console.ReadLine());
double calculation (int number, int degree)
{
    bool flag = degree > 0;
    if (degree < 0) degree = - degree;
    int result = 1;
    for (int i = 0; i < degree; i++) result *= number;
    if (flag) return result;
    else return 1.0 / result;
}
double output = calculation (number, degree);
Console.WriteLine ($"Number {number} in degree {degree} alike {output}");
