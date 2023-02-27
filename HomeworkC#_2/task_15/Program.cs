// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int randomNum = new Random().Next(1, 8);
Console.WriteLine($"Сгенерированно число {randomNum}");

if ((randomNum == 6) || (randomNum == 7)) Console.WriteLine("да");
else Console.WriteLine("нет");