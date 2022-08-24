// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Введите любое целое отличное от 0 число без лидирующих нулей: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
{
    Console.WriteLine("Вы ввели ноль. Повторите ввод отличного от 0 целого числа.");
    Environment.Exit(50); // Код системной ошибки 50 (0x32)  - Запрос не поддерживается.
}

int absol = Math.Abs(number);

int counter = 0;
while (absol > 0)
{
    counter++;
    absol = absol / 10;
}
Console.WriteLine("Данное число содержит цифр: " + counter);
