// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int n){
  int[] tempArr = new int[n];

  for (int i = 0; i < tempArr.Length; i++){
    tempArr[i] = new Random().Next(100, 1000);
  }
  return tempArr;
}

void PrintArray(int[] arr){
  foreach(int i in arr) Console.Write($"{i} ");
  Console.WriteLine();
}

int CheckEven(int[] tempArr){
  int count = 0;

  foreach(int i in tempArr){
    if(i % 2 == 0) count++;
  }

  return count;
}


int[] array = CreateArray(10);
PrintArray(array);
Console.WriteLine(CheckEven(array));