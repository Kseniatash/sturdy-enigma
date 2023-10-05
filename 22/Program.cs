// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// int n = 6;

// 1  1
// 2  4
// 3  9
// 4  16
// 5  25

void TableSqure(int num) 
{
    int count = 1;
    while (count <= num)
    {
       Console.WriteLine($"{count,3} {count*count,5}") ;
       count++;

    }
}


Console.WriteLine( "Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());

TableSqure(num);