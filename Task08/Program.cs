﻿// Задача 8: Напишите программу, которая 
// 1.на вход принимает число (N),
// 2. а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число:");
int number =Convert.ToInt32(Console.ReadLine());
int count = 1;

{ 
    if ( number>0)
    while (count%2==0)
  
{
    Console.WriteLine($"{count} являются четными");
    count++;
}
}
