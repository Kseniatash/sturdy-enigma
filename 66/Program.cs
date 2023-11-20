// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumTotDigit(int min, int max)
{
    int currentSum = max;
    if (max> min)
    {
      currentSum += SumTotDigit (min, max - 1);
    }
    return currentSum;
}


Console.WriteLine("Введите число M:  ");
int minimum  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:  ");
int maximum = Convert.ToInt32(Console.ReadLine());
if(maximum < minimum)
{
    Console.WriteLine("Некорректный ввод");
    return;
}
else
{
   int sum = SumTotDigit(minimum,maximum);
   Console.WriteLine($"Сумма натуральных чисел в заданном промежутке : {sum}");
}



