﻿// Напишите программу, которая 
// 1.на вход принимает число и 
// 2.выдаёт его квадрат (число умноженное на само себя).
// 3.Вывод результата
// Например:

// 4 -> 16
// -3 -> 9
// -7 -> 49


Console.WriteLine("Введите целое число");
int number =  Convert.ToInt32(Console.ReadLine());

int square = number * number;


Console.WriteLine($"{number} -> {square}");


// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2*number2)
{
    Console.WriteLine($"{number1} является квадратом {number2}");
}
else
{
    Console.WriteLine("${number1} не является квадратом {number2}");
}
