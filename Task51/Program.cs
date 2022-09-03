// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

//Метод создания массива
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
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

int SumDiag(int[,] matrix)
{
    int sum = 0;
    int len = matrix.GetLength(1);
    if (matrix.GetLength(1) >= matrix.GetLength(0))
    {
        len = matrix.GetLength(0);
    }
    for (int i = 0; i < len; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int[,] array2d = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(array2d);
Console.WriteLine("-------");
Console.WriteLine(SumDiag(array2d));

// int SumOfMainDiagonalValue (int[,] matrix)
// {
//     int result = 0;
//     for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
//     {
//         result += matrix[i, i];
//     }
//     return result;
// }

// int[,] matrix2D = CreateMatrixRndInt (5, 3, 1, 5);
// PrintMatrix(matrix2D);
// Console.WriteLine($"Найдите сумму элементов, находящихся на главной диагонали: {SumOfMainDiagonalValue (matrix2D)}");
