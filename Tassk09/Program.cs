// 9. Напишите программу, которая выводит
// 1.случайное число из отрезка [10, 99] и показывает
// 2.наибольшую цифру числа.
// 
//78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 99+1); //max = 99+1
Console.WriteLine($"случайное число из отрезка [10, 99] -> {number}");

int firstDigit = number / 10; // 78/10 = 7.8
int secondDigit = number /10; 

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int maxDigit = firstDigit >secondDigit? firstDigit:secondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");



int MaxDigit(int num)
{

    int firstDigit = num / 10;
    int secondDigit = num /10; 
    return firstDigit >secondDigit? firstDigit:secondDigit;

}

int maxDigit3 = MaxDigit(89);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit3}");


// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);
int firstDigit = number /100;
int lastDigit = number /10;
int numResult = firstDigit*10 + lastDigit;
Cosole.WriteLine($"{number} ->{numResult} ");