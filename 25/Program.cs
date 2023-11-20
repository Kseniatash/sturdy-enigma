//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

static double power3(double a, int b) {
  if (b < 0) { (a, b) = (1.0 / a, -b); }
  double res = 1.0;
  for (; b != 0; a *= a, b /= 2) {
    if (b % 2 != 0) { res *= a; }
  }
  return res;  
}



Console.WriteLine("Введите целое чиcло a");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое чиcло b");
int num1 = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine( );