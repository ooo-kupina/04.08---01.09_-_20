// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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

void ReverseArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

int[,] array2d = CreateMatrixRndInt(3, 5, 0, 10);
PrintMatrix(array2d);
Console.WriteLine("-------");
ReverseArray(array2d);
PrintMatrix(array2d);

