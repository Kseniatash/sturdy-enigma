// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели:");
string weekDay = Console.ReadLine();

if (weekDay=="1")
   Console.WriteLine($"{weekDay}-> Рабочий");
else if (weekDay=="2")
   Console.WriteLine($"{weekDay}-> Рабочий");
else if (weekDay=="3")
   Console.WriteLine($"{weekDay}-> Рабочий");
else if (weekDay=="4")
   Console.WriteLine($"{weekDay}-> Рабочий");
else if (weekDay=="5")
   Console.WriteLine($"{weekDay}-> Рабочий");
else if (weekDay=="6")
   Console.WriteLine($"{weekDay}-> Выходной");
else if (weekDay=="7")
   Console.WriteLine($"{weekDay}-> Выходной");
else 
    Console.WriteLine("Некорректный ввод");