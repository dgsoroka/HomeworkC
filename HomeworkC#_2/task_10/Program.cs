﻿// Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int randomNum = new Random().Next(1, 1000);
int secondNum = (randomNum / 10) % 10;

Console.WriteLine($"Сгенерированно число {randomNum}");
Console.WriteLine($"Вторая цифра сгенерированного числа - {secondNum}");