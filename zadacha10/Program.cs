﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число на разбор: ");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x % 100 /10;
Console.WriteLine($"центральное число - {x1}");