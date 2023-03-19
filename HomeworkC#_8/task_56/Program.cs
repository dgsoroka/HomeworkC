// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void LineSum(int[,] arr){
  int sum = 0;
  List<int> sumList = new List<int>();
  for(int i = 0; i < arr.GetLength(0); i++){
    for(int j = 0; j < arr.GetLength(1); j++){
      sum += arr[i, j];
    }
    sumList.Add(sum);
    sum = 0;
  }


  int minSum = sumList[0];
  int count = 1;

  foreach(int i in sumList){
    if(i < minSum) minSum = i;

  }
  foreach(int i in sumList){
    if(i == minSum) break;
    count++;
  }
  Console.WriteLine($"Наименьшая сумма равна {minSum}, строка {count}");
}


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine();
LineSum(array);