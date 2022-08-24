// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// Была заметка: Доделать эту задачу!!! Я доделала, вроде. Но надо алгоритм сделать универсальным для чётных и нечётных массивов
// int[] array = CreateArrayRndInt(5, 1, 10);
// PrintArray(array);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int i = 0;
    Console.Write("[");
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[i]}");
    Console.Write("]");
    Console.WriteLine();
}




int[] CompositionArray(int[] array1)
{
    int size1 = 0;
    if (array1.Length % 2 == 0) size1 = array1.Length / 2;
    else size1 = (array1.Length / 2) + 1;
    int[] result = new int[size1];
    for (int i = 0; i < array1.Length / 2; i++)
    {
        result[i] = array1[i] * array1[array1.Length - i - 1];
    }
    if (array1.Length % 2 != 0) result[size1 - 1] = array1[array1.Length / 2];

    return result;
}

int[] array2 = CreateArrayRndInt(7, 1, 10);
PrintArray(array2);
int[] result2 = CompositionArray(array2);
PrintArray(result2);

