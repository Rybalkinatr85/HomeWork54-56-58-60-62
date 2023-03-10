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

Write("Введите количество строк первой матрицы: ");
int rows1 = int.Parse(Console.ReadLine()!);
Write("Введите количество столбцов первой матрицы: ");
int columns1 = int.Parse(Console.ReadLine()!);

Write("Введите количество строк второй матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);
Write("Введите количество столбцов второй матрицы: ");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix)
{
    int[,] rezultMatrix = new int [firstMartrix.GetLength(0), secomdMartrix.GetLength(1)];
    for (int i = 0; i < firstMartrix.GetLength(0); i++)
    {
        for (int j = 0; j < secomdMartrix.GetLength(1); j++)
        {
            
            rezultMatrix[i, j] = firstMartrix[i,j] * secomdMartrix[i,j] ;
        }
    }
    return rezultMatrix;
}

// Метод заполнения массива рандомно числами от 1 до 10
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 11);;
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
int[,] firstMartrix = GetArray(rows1, columns1);
WriteLine($"Первая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = GetArray(rows2, columns2);
WriteLine($"Вторая матрица:");
PrintArray(secomdMartrix);

int[,] result = MultiplyMatrix(firstMartrix, secomdMartrix);
WriteLine($"Произведение первой и второй матриц:");
PrintArray(result);