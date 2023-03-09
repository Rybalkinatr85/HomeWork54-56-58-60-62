// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;

Clear();

// WriteLine("Введите размеры матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");

Write("Введите количество строк первой матрицы: ");
int rows1 = int.Parse(ReadLine()!);
Write("Введите количество столбцов первой матрицы: ");
int columns1 = int.Parse(ReadLine()!);

Write("Введите количество строк второй матрицы: ");
int rows2 = int.Parse(ReadLine()!);
Write("Введите количество столбцов второй матрицы: ");
int columns2 = int.Parse(ReadLine()!);


int[,] firstMartrix = GetArray[rows1, columns1, 0, 10];

WriteLine($"Первая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = GetArray[rows2, columns2, 0, 10];

WriteLine($"Вторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = GetArray[rows1, columns2];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

// Метод заполнения массива рандомно числами от 1 до 9
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

// Метод вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}
