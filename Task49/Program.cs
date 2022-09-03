// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.


// квадраты
int[,] CreateMatrixRnd(int row, int col, int min, int max)
{
    int[,] matrix = new int[row,col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)   //row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   //col
        {
            matrix[i,j] = rnd.Next(min,max+1);
        }
        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j],4}");
        if (j != matrix.GetLength(1)-1) Console.Write(",");
    }
    Console.Write("]");
    Console.WriteLine();
    }
}
int[,] mat = CreateMatrixRnd(4,4,0,10);
PrintMatrix(mat);
Console.WriteLine();

void QuatroMtrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i%2==0 && j%2==0)
        {
            matrix[i,j]=matrix[i,j]*matrix[i,j];
}
    }
    }
}
QuatroMtrix(mat);
PrintMatrix(mat);
