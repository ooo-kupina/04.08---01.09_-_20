﻿// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i}\t{i * i}");
    }
}
else Console.WriteLine("Введено некорректное значение");


// Ещё одно решение выведено в отдельную задачу
