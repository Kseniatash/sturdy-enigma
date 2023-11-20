// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumDigit(int num)

{
    int result = 0;
    while (num>0)
    {
       result += num % 10;
        num = num / 10;
        
    }
     return result ;
}


Console.WriteLine("Введите целое чиcло");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех чисел в в цифре {num} = {SumDigit(num)}");