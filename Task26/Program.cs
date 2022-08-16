// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int absol = Math.Abs(number);

int counter = 0;
while (absol > 0)
{
    counter++;
    absol = absol / 10;
}
Console.WriteLine("Данное число содержит цифр: " + counter);
