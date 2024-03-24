// Программа, которая принимает на вход трехзначное число и возводит вторую цифру этого числа в степень, равную третьей цифре

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;
int result = 1;

if (num >= 100 && num <= 999 || num <= -100 && num >= -999)
{
    int digit2 = num / 10 % 10;
    int digit3 = num % 10;

    while (count < digit3) // Почему <, а не <=, потому что count начинаем с нуля, а не с 1
    {
        result = result * digit2;
        count++;
    }
    Console.Write(result);
}
else
{
    Console.WriteLine("Некорректный ввод");
}