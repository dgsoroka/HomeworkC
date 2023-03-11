// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(int n){
  double[] tempArr = new double[n];

  for (int i = 0; i < tempArr.Length; i++){
    tempArr[i] = new Random().Next(-50, 51);
  }
  return tempArr;
}

void PrintArray(double[] arr){
  foreach(int i in arr) Console.Write($"{i} ");
  Console.WriteLine();
}

double MaxMinDiff(double[] arr){
  return arr.Max() - arr.Min();
}


double[] array = CreateArray(10);
PrintArray(array);
Console.WriteLine(MaxMinDiff(array));