// 1. На вход трехзначное число 
// 2. на выходе последнюю цифру этого числа 
// 456 -> 6
// 782  ->2
// 918 -> 8

Console.WriteLine("Введите трехзначное целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number >= 100 && number <= 999)

{

    int lostDigit = number % 10;

    Console.WriteLine($"Последняя цифра числа: {lostDigit}");
}
else  Console.WriteLine("Некорректный ввод");

