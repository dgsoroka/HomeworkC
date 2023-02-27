// В институте биоинформатики по офису передвигается робот.
// Недавно студенты из группы программистов написали для него программу,
// по которой робот, когда заходит в комнату, считает количество программистов
// в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное
// окончание слова.
// Напишите программу,
// считывающую с пользовательского ввода целое число n (неотрицательное),
// выводящее это число в консоль вместе с правильным образом изменённым
// словом "программист", для того, чтобы робот мог нормально общаться с людьми,
// например: 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте,
// что ваша программа правильно обработает все случаи, как минимум до 1000 человек.

int randomNum = new Random().Next(1, 1001);
Console.WriteLine($"Сгенерированно число {randomNum}");
int tempNum = randomNum;


if ((randomNum > 9) && (randomNum < 21))
{
  Console.WriteLine($"{randomNum} программистов");
}
else if (randomNum < 10)
{
  if (Enumerable.Range(2, 4).Contains(randomNum)) Console.WriteLine($"{randomNum} программиста");
  else if (randomNum == 1) Console.WriteLine($"{randomNum} программист");
  else if (Enumerable.Range(5, 10).Contains(randomNum)) Console.WriteLine($"{randomNum} программистов");
}
else if (randomNum < 100)
{
  while (tempNum >= 10) tempNum = tempNum % 10;
  if (Enumerable.Range(2, 4).Contains(tempNum)) Console.WriteLine($"{randomNum} программиста");
  else if (tempNum == 1) Console.WriteLine($"{randomNum} программист");
  else if (tempNum == 0) Console.WriteLine($"{randomNum} программистов");
  else if (Enumerable.Range(5, 10).Contains(tempNum)) Console.WriteLine($"{randomNum} программистов");
}