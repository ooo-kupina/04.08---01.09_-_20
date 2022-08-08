// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 10, 99 + 1
Console.WriteLine($"Случайное число из диапазона 10-99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit == secondDigit) Console.WriteLine("Цифры равны");
else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшиая цифра числа {number} => {firstDigit}");
else Console.WriteLine($"Наибольшиая цифра числа {number} => {secondDigit}");

int result = firstDigit == secondDigit ? "Цифры равны"
 : firstDigit > secondDigit ? firstDigit.ToString() : secondDigit.ToString();
int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшиая цифра числа {number} => {result}");