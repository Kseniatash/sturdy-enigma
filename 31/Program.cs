// Задача 31: 1.Задайте массив из 12 элементов, заполненный
// 2 случайными числами из промежутка [-9, 9].
//  Найдите 3 сумму
// отрицательных и положительных элементов массива.
// htpekmnfn
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

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
void PrintArray(int[]arr)
{
    // Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i<arr.Length-1)Console.Write($"{arr[i]},  ");
        else Console.Write($"{arr[i]}");
    }
    // Console.Write("]");
}
// 1 способ
int[]GetSumPositivNegativElem(int[]arr)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0 )sumPositive+=arr[i];
        else sumNegative +=arr[i];
    }
    
    return new int[] {sumPositive,sumNegative};
}

// 2 способ
int GetSumPositivElem(int[]arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) sum+=arr[i];
    }
    return sum;
}

int GetSumNegativElem(int[]arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<0) sum+=arr[i];
    }
    return sum;
}

int[]array = CreateArrayRndInt(12,-9,9);
Console.Write("[");
PrintArray(array);
Console.Write("]");

// первый способ
int [] sumPositivNegativElem = GetSumPositivNegativElem(array);
Console.WriteLine($"Сумма положительных элементов-> {sumPositivNegativElem[0]}"); 
Console.WriteLine($"Сумма отрицательных элементов-> {sumPositivNegativElem[1]}");

// второй способ вывода
int sumPositivElem = GetSumPositivElem(array);
int sumNegativElem = GetSumNegativElem(array);
Console.WriteLine($"Сумма положительных элементов-> {sumPositivElem}");
Console.WriteLine($"Сумма отрицательных элементов-> {sumNegativElem}");