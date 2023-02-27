// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int randomNum = new Random().Next(1, 99999999);
int thirdNum = 0;
Console.WriteLine($"Сгенерированно число {randomNum}");

if (randomNum > 99){
  while (randomNum > 999) randomNum = randomNum / 10;
  thirdNum = randomNum % 10;
  Console.WriteLine($"Третья цифра сгенерированного числа равна {thirdNum}");
} else Console.WriteLine($"Число {randomNum} не имеет третьей цифры");