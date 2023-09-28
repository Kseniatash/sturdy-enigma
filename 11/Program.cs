//  Напишите программу, 
//  1.которая принимает на вход трёхзначное число и 
//  2.на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите  трехзначное число :");
int number =Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

System.Console.WriteLine(); 