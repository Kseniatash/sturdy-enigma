// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

int SumElemColums(int[ , ] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       
    }

}

int[ , ] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows,columns]; // rows = 3  , colums = 4 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i, j] = rnd.Next(min,max+1);
        }
        
    }
    return matrix;
}

void PrintMatrix(int[ , ]matrix)
{
    
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i,j], 5} ");
        }
        Console.WriteLine(" |");
    }   
 
}

int [,] array2d = CreateMatrixRndInt(3,4, -100,100);
PrintMatrix(array2d);
int res = SumElemColums(array2d);
