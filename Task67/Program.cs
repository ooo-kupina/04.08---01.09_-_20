// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// 

int SumDigitals(int number)
{
    int sum = number % 10;
    if (number == 0) return sum;
    return sum += SumDigitals(number / 10);
}
int result = SumDigitals(453);
System.Console.WriteLine($"453 -> {result}");