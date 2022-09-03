// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


System.Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

void ShowNumbers(int a, int b)
{
    if(a < b)
    {
        Console.Write($"{a} ");
        ShowNumbers(a + 1, b);
    }
    if (a > b)
    {
        Console.Write($"{a} ");
        ShowNumbers(a - 1, b);
    }
    if(a == b)
    {
        Console.Write($"{a} ");
    }
}

ShowNumbers(m, n);
