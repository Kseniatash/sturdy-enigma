// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int GenerateArray(int Length,int minValue,int maxValue) 

// {
//    int[] array = new int [8];
//    Random random = new Random();
//       for (int i = 0; i > Length; i++)
//     {
//     array[i] = random.Next(minValue,maxValue +1);
    
//      }
// return  generateArray = GenerateArray ;
// }

// }

// void array (int[]array,)
// {
//     //     for (int i = 0; i < array.length -1; i++)
//     {
//         Console.Write($"{array[i]},  ");
//     }
//     Console.Write($"{array[array.Length -1]}");
//     Console.WriteLine("[ ]");
// }

// int[] array = new int [5]{1,2,5,7,19};

// // array[0] = 1;
// // array[1] = 2;
// // array[2] = 5;
// // array[3] = 7;
// // array[4] = 19;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i;
//     Console.Write(array[i] + "  ");

//     Console.Write($"{array[array.Length -1]}");
    
// }

int[] Array(int size)
{
  int [] array = new int [8];
  Random rnd = new Random();
  for (int i = 0; i < size; i++)
  {
    array[i] = rnd.Next(8);
  }
  return array; 
}

void PrintArray(int[] array)
{
    //  Console.Write("[");
 for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + "  ");
  }
//    Console.Write("]");
}

int[] arr = Array(8);
PrintArray(arr);
Console.Write("  -> [");
PrintArray(arr);
Console.Write("  ]");