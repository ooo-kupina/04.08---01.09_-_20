// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

//Метод создания массива
int[,] CreateIntMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rmd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rmd.Next(min, max + 1);
        }
    }
    return matrix;
}

//Метод вывода массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1)) Console.Write($"{matrix[i, j],3}");
            else Console.Write(matrix[i, j]);
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}


void Dictionary(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }

    Array.Sort(array);

    int count = 1;
    int value = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != value)
        {
            Console.WriteLine($"Значение {value} встречается {count} раз");
            value = array[i];
            count = 1;
        }
        else
        {
            value = array[i];
            count++;
        }
    }
    Console.WriteLine($"Значение {value} встречается {count} раз");
}

int[,] mtrx = CreateIntMatrix(4, 3, 1, 9);
PrintMatrix(mtrx);

Console.WriteLine();

Dictionary(mtrx);
