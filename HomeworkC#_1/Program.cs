// 2 задача Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
try
{
  Console.Write("Введите первое число: ");
  int firstNum1 = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите второе число: ");
  int secondNum1 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Наибольшее число - {0}, наименьшее - {1}", Math.Max(firstNum1, secondNum1), Math.Min(firstNum1, secondNum1));
}
catch (System.FormatException)
{
  Console.WriteLine("Введен неверный формат");
}


// 4 задача Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

try
{
  Console.Write("Введите первое число: ");
  int firstNum2 = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите второе число: ");
  int secondNum2 = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите третье число: ");
  int thirdNum2 = Convert.ToInt32(Console.ReadLine());

  int maxVal = 0;

  if (firstNum2 >= maxVal) maxVal = firstNum2;
  if (secondNum2 >= maxVal) maxVal = secondNum2;
  if (thirdNum2 >= maxVal) maxVal = thirdNum2;

  Console.WriteLine("Максимальное число среди этих трех - {0}", maxVal);
}
catch (System.FormatException)
{
  Console.WriteLine("Введен неверный формат");
}


// 6 задача Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
try
{
  Console.Write("Введите число: ");
  int firstNum3 = Convert.ToInt32(Console.ReadLine());

  if ((firstNum3 % 2) == 0) Console.WriteLine("Число {0} является четным", firstNum3);
  else Console.WriteLine("Число {0} является нечетным", firstNum3);
}
catch (System.FormatException)
{
  Console.WriteLine("Введен неверный формат");
}


// 8 задача Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
try
{
  Console.Write("Введите число: ");
  int firstNum4 = Convert.ToInt32(Console.ReadLine());

  for (int i = 2; i <= firstNum4; i += 2)
  {
    if ((i % 2) == 0) Console.Write("{0} ", i);
  }
  Console.WriteLine();
}
catch (System.FormatException)
{
  Console.WriteLine("Введен неверный формат");
}


// 7 задача Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

try
{
  Console.Write("Введите любое положительное число: ");
  int anyNum = Convert.ToInt32(Console.ReadLine());
  int thirdDigit = 0;
  if (anyNum >= 100)
  {

    while (anyNum > 999) anyNum = anyNum / 10;

    thirdDigit = anyNum % 10;
    Console.Write("Третья цифра слева равна {0}", thirdDigit);

  }
  else Console.WriteLine("Число меньше трехзначного или является отрицательным");
}
catch (System.FormatException)
{
  Console.WriteLine("Неверный формат данных");
}
