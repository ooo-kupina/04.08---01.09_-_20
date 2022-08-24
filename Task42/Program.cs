/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */


// int[] b = new int[10];
// while (num10 >= 1)
//         {
//             a = num10 % 2;
//             b[i] = a;
//             i++;
 
//             num10 = num10 / 2;
// for (i = (b.Length - 1); i >= 0; i--)
//         {
//             Console.Write(b[i]);


Console.WriteLine("Введите целое положительное число: ");
int num = int.Parse(Console.ReadLine());

int result = 0;
int mult = 1;
while(num > 0)
{
    result += num % 2 * mult;
    num = num / 2;
    mult *= 10;
}

Console.WriteLine(result);
