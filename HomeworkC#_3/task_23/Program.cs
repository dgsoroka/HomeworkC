// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string SquareTable(int n)
{
  string rst = String.Empty;

  for (int i = 1; i < n; i++)
  {
    rst = rst + Math.Pow(i, 3) + ", ";
  }
  rst = rst + Math.Pow(n, 3);

  return rst;
}

Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SquareTable(number));