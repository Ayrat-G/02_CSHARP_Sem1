/* Напишите программу, которая на вход принимает два целых числа, и проверяет, является ли первое число квадратом второго */

Console.WriteLine("Введите первое число: ");
String num1Str = Console.ReadLine();
int num1 = Convert.ToInt32(num1Str);

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// int num1 = 25;
// int num2 = 5;

if (num1 == num2 * num2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
