// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) ,
//  причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива,
//   причем чтобы каждый элемент гарантированно и только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций.
//   То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.

void Shuffle(Random random, int[,] arr)
{
    int rowLen = arr.GetLength(1);

    for (int i = arr.Length - 1; i > 0; i--)
    {
        int i0 = i / rowLen;
        int i1 = i % rowLen;

        int j = random.Next(i + 1);
        int j0 = j / rowLen;
        int j1 = j % rowLen;

        int temp = arr[i0, i1];
        arr[i0, i1] = arr[j0, j1];
        arr[j0, j1] = temp;
    }
}

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

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Shuffle(new Random(), array);
Console.WriteLine();
PrintArray(array);