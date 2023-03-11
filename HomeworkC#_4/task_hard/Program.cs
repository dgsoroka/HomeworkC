// Задача HARD STAT необязательная: Задайте массив случайных целых чисел.
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс,
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

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

double GetMedian(int[] arr){
   int[] sortedPNumbers = (int[]) arr.Clone();
        Array.Sort(sortedPNumbers);

        int size = sortedPNumbers.Length;
        int mid = size / 2;
        double median = (size % 2 != 0) ? (double)sortedPNumbers[mid] : ((double)sortedPNumbers[mid] + (double)sortedPNumbers[mid - 1]) / 2;
        return median;
    }

decimal[] MinMaxIndexMedArif(int[] arr){
  List<decimal> newArr = new List<decimal>();

  int maxNum = arr.Max();
  int minNum = arr.Min();

  int maxIndex = Array.FindIndex(arr, delegate(int a){ return a == arr.Max();});
  int minIndex = Array.FindIndex(arr, delegate(int a){ return a == arr.Min();});

  int sum = new int();
  decimal medArifm = new decimal();

  foreach(int i in arr) sum += i;

  medArifm = sum / arr.Length;

  newArr.Add(minNum);
  newArr.Add(minIndex);
  newArr.Add(maxNum);
  newArr.Add(maxIndex);
  newArr.Add(medArifm);

  return newArr.ToArray();
}


int[] array = CreateArray(10);
PrintArray(array);
decimal[] secondArray = MinMaxIndexMedArif(array);
Console.WriteLine($"Минимальное значение в массиве равно {secondArray[0]}, его индекс {secondArray[1]}.\n" +
                  $"Максимальное значение в массиве равно {secondArray[2]}, его индекс {secondArray[3]}.\n" +
                  $"Среднее арифметическое равно {secondArray[4]}");
Console.WriteLine($"Медианное значение массива равно {GetMedian(array)}");
