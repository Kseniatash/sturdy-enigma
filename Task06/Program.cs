// Задача 6: 
//1/Напишите программу, которая на вход принимает число и 
//2.выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2==0)

{
    Console.WriteLine($"{number} является четным числом");
}
else 
{
    Console.WriteLine($"{number} является нечетным числом");
}

