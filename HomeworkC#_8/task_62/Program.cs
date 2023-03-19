// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// На входе - натуральное число от пользователя, например 4.
// Тогда на выходе получается вот такой массив:


void SpiralArray()
{
  Console.Write("Введите размер массива: ");
  int n = Convert.ToInt32(Console.ReadLine());

  int[,] arr = new int[n, n];
  int count = 1;

  int row = 0, col = 0;
  while (count <= n * n)
  {
    for (int i = col; i < n - col; i++)
    {
      arr[row, i] = count;
      count++;
    }
    for (int i = row + 1; i < n - row; i++)
    {
      arr[i, n - col - 1] = count;
      count++;
    }
    for (int i = n - col - 2; i >= col; i--)
    {
      arr[n - row - 1, i] = count;
      count++;
    }
    for (int i = n - row - 2; i > row; i--)
    {
      arr[i, col] = count;
      count++;
    }
    row++;
    col++;
  }

  Console.WriteLine("Спиральный массив:");
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < n; j++)
    {
      Console.Write("{0, 3}", arr[i, j]);
    }
    Console.WriteLine();
  }
}


SpiralArray();