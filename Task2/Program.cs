// Задача 2: Напишите программу, 
//1.которая на вход принимает два числа и 
//2.выдаёт, какое число большее,
//3. а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 < number2)
if (number2 > number1)
{
    Console.WriteLine($"{number1} является меньшим числом");
    Console.WriteLine($"{number2} является большим числом");
}

