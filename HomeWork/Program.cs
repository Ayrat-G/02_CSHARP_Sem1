// Программа, которая на вход принимает два числа и выводит, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(num1 + " - большее число");
    Console.WriteLine(num2 + " - меньшее число");
}
else
{
    if (num1 < num2)
    {
        Console.WriteLine(num1 + " - меньшее число");
        Console.WriteLine(num2 + " - большее число");
    }
    else
    {
        Console.WriteLine("Оба числа между собой равны");
    }
}