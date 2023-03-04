// Напишите программу,
// которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве.
// Сначала задается N с клавиатуры, потом задаются координаты точек.

double[] CreateArray(int n)
{
  double[] tempArr = new double[n];
  for (int i = 0; i < tempArr.Length; i++)
  {
    Console.Write($"Введите следующую координату в {n}-мерном пространстве: ");
    double tempNum = Convert.ToDouble(Console.ReadLine());
    tempArr[i] = (tempNum);
  }
  return tempArr;
}



double NDistance(double[] firstArr, double[] secondArr)
{
  double sum = new double();
  double rst = new double();

  for (int i = 0; i < firstArr.Length; i++) sum = sum + Math.Pow(firstArr[i] - secondArr[i], 2);
  rst = Math.Sqrt(sum);
  return rst;
}

Console.Write("Введите количество измерений пространства: ");
int dimensionsNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Начинайте вводить координаты первой точки: ");
double[] firstArr = CreateArray(dimensionsNum);
Console.WriteLine("Начинайте вводить координаты второй точки: ");
double[] secondArr = CreateArray(dimensionsNum);

Console.WriteLine($"Расстояние между точками в {dimensionsNum} мерном измерении равно - {Math.Round(NDistance(firstArr, secondArr), 2)}");