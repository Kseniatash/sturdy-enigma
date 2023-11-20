// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

int[ ] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min,max+1);
    }
    return arr;
}

 int CountNumbersInRange(int []array, int min, int max)
 {
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i]>= min && array[i]<= max)
         count++;
    }
    return count;
 }


void PrintArray(int[]arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i<arr.Length-1)Console.Write($"{arr[i]},  ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}



int [] array =  CreateArrayRndInt(123, -100,100); 

Console.Write("[");
PrintArray( array);
Console.Write("]");

int result = CountNumbersInRange(array, 10,99);
Console.WriteLine($"Количество двузначных чисел-> {result}");

// Console.WriteLine("Введите число для поиска");
// int num = Convert.ToInt32(Console.ReadLine());
// bool result = FindNumber(array,num);
// Console.WriteLine(result? "искомое число найдено": "искомое число не найдено");