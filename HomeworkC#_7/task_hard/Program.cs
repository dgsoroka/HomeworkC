// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(-30, 31);
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j],3} \t");
    Console.WriteLine();
  }
}

void SortArray(int[,] tempArr)
{
  int a = 0;
  int[] oneDArr = new int[tempArr.Length];
    for (int i = 0; i < tempArr.GetLength(0); i++)
      for (int j = 0; j < tempArr.GetLength(1); j++)
      {
        oneDArr[a] = tempArr[i, j];
        a++;
      }
  a = 0;
  Array.Sort(oneDArr);

  for (int i = 0; i < tempArr.GetLength(0); i++)
      for (int j = 0; j < tempArr.GetLength(1); j++)
      {
        tempArr[i, j] = oneDArr[a];
        a++;
      }
}


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);