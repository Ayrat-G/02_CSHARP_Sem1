// Программа, которая принимает на вход трехзначное число и удаляет вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999 || num <= -100 && num >= -999)
{
    int digit1 = num / 100;
    int digit3 = num % 10;
    int result = digit1 * 10 + digit3;
    Console.Write(result);
}
else
{
    Console.WriteLine("Некорректный ввод");
}