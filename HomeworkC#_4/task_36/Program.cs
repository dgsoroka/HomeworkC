// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int n){
  int[] tempArr = new int[n];

  for (int i = 0; i < tempArr.Length; i++){
    tempArr[i] = new Random().Next(-50, 51);
  }
  return tempArr;
}

void PrintArray(int[] arr){
  foreach(int i in arr) Console.Write($"{i} ");
  Console.WriteLine();
}

int OddSum(int[] tempArr){
  int sum = new int();

  for(int i = 1; i < tempArr.Length; i+=2){
    sum += tempArr[i];
  }

  return sum;
}


int[] array = CreateArray(10);
PrintArray(array);
Console.WriteLine(OddSum(array));