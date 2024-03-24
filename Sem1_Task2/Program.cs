﻿// Напишите программу, которая на входе принимает целое число N, а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 0) 
{
    // Задаем начальное значение отсчета (перебора значений)
    int count = -num;

    // Циклом while перебираем все значения с начальной точки -num до num
    while (count <= num)
    {
        Console.Write(count + " "); // Печать значений в строчку с пробелом
        count++;    // Это означает count = count + 1
    }    
}
else
{
        Console.WriteLine("Некорректный ввод!");
}
