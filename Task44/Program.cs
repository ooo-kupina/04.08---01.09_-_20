// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Write("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// int num1 = 0;
// int num2 = 1;
// int i = 0;

// while (i < number)
// {
//     Console.Write($"{num1} {num2} ");
//     num1+=num2;
//     num2+=num1;
//     i++;
// }

// void Fib(int num0)
// {
//     int num1 = 0;
//     int num2 = 1;
//     int i = 0;

//     while (i < num0)
//     {
//         Console.Write($"{num1} {num2} ");
//         num1 += num2;
//         num2 += num1;
//         i++;
//     }
// }

// Console.Write("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// Fib(number);


// Console.Write("Введите целое положительное число: ");
// int number = int.Parse(Console.ReadLine());

// void ShowFibonacci(int num)
// {
//     int num1 = 0;
//     int num2 = 1;
    
//     Console.Write(num1+" "+num2+" ");

//     for (int i = 2; i < num; i++)
//     {
//         int temp = num1 + num2;
//         num1 = num2;
//         num2 = temp;
//         Console.Write(temp+" ");    
//     }
//     Console.WriteLine();
// }

// ShowFibonacci(number);

int number = 56;

void DecToBin(int num)
{
    if(num == 0) return;
    DecToBin(num / 2);
    Console.Write(num % 2); 
}

DecToBin(number);
