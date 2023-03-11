// Задача 27. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

int NumLength(decimal n)
{
  int count = 1;
  if ((n % 1) > 0){
    while ((n % 1) > 0){
      n = n * 10;
    }
  }

  while (n > 10)
  {
    n = n / 10;
    count++;
  }
  return count;
}

Console.WriteLine(NumLength((decimal) 13.054));