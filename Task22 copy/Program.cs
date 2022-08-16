// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// Ещё одно решение вывести в отдельную задачу
Console.WriteLine("Введите значение: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;
if (num > 0)
{
   while (i <= num)
   {
       int q = i * i;
       Console.WriteLine($"{i}   {q}");
       i++;
   }
}
else 
{
    Console.WriteLine("Введите значение больше 0!");
}

