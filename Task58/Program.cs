// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max)
{
    int[,] matrixA = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            matrixA[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrixA;
}

int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
{
    int[,] matrixB = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixB[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrixB;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixAB = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int n = 0; n < matrixB.GetLength(0); n++)
            {
                matrixAB[i, j] += matrixA[i, n] * matrixB[n, j];
            }
        }
    }
    return matrixAB;
}


int[,] matrixA = CreateMatrixRndInt1(2, 2, 1, 10);
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = CreateMatrixRndInt2(2, 2, 1, 10);
PrintMatrix(matrixB);
Console.WriteLine();
int[,] matrixAB = MultiplicationMatrix(matrixA, matrixB);
if (matrixA.GetLength(1) != matrixB.GetLength(0)) Console.WriteLine("Невозможно перемножить матрицы");
else PrintMatrix(matrixAB);