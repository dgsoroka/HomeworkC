// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(1, 10);
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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
  int rowsFirstMatrix = firstMatrix.GetLength(0);
  int colsFirstMatrix = firstMatrix.GetLength(1);
  int rowsSecondMatrix = secondMatrix.GetLength(0);
  int colsSecondMatrix = secondMatrix.GetLength(1);

  if (colsFirstMatrix != rowsSecondMatrix){ 
    Console.WriteLine("Матрицы нельзя умножить");
    return new int[0, 0];
  }
  else
  {
    int[,] resultMatrix = new int[rowsFirstMatrix, colsSecondMatrix];

    for (int i = 0; i < rowsFirstMatrix; i++)
      for (int j = 0; j < colsSecondMatrix; j++)
      {
        int sum = 0;
        for (int k = 0; k < colsFirstMatrix; k++) sum += firstMatrix[i, k] * secondMatrix[k, j];
        resultMatrix[i, j] = sum;
      }
      return resultMatrix;
    }
}


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
int[,] array2 = new int[rows, cols];
FillArray(array);
FillArray(array2);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(MatrixMultiplication(array, array2));