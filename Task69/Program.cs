// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


// int Degree(int numc, int degc)
// {
//     int res = 1;
//     for (int i = 1; i <= degc; i++)
//     {
//         res = res * numc;
//     }
//     return res;
// }

// Console.Write("Введите число A: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите степень B: ");
// int deg = Convert.ToInt32(Console.ReadLine());

// int result = Degree(num, deg);
// Console.WriteLine($"Результат возведения числа А = {num} в степень B = {deg} равен: {result}");


Console.WriteLine("Введитe целое положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитe целое положительное число (степень): ");
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * Degree(num1, num2 - 1);
}
Console.WriteLine(Degree(a, b));