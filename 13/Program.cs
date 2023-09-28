//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите  целое число :");
int number =Convert.ToInt32(Console.ReadLine());


if (number/100>0) System.Console.WriteLine($"третьей цифрой числа {number} является {number / 100 % 10} ");
else System.Console.WriteLine($" третьей цифры числа  {number}  не существует");



    


