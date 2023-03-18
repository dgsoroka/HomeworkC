// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(-10, 11);
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

 Dictionary<string, int> NumSearch(int[,] arr ,int num){
  Dictionary<string, int> rst = new Dictionary<string, int>();
  rst.Add("i", int.MinValue);
  rst.Add("j", int.MinValue);
  for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++){
      if (num == arr[i, j]){
        rst["i"] = i;
        rst["j"] =  j;
      } 
    }
    return rst;
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
foreach(KeyValuePair<string, int> kvp in NumSearch(array, 5)){
  if(kvp.Value == int.MinValue){
    Console.WriteLine("Числа нет в массиве");
    break;
  }
  Console.Write($"{kvp.Key}:{kvp.Value} ");
}