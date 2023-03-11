/*Задача 61: Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника.
*/

using System;
using static System.Console;

Clear();

Write("Введите количество строк треугольника Паскаля: ");
int numberRows = int.Parse(ReadLine()!);

///Метод заполнения массива алгоритмом Паскаля:
int [,] GetArray (int numberRows)
{
    int rows = numberRows;
    int columns = numberRows + 2;
    int [,] array = new int [rows, columns];
    array[0, 0] = 0;
    array[0, 1] = 1;
    array[0, 2] = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
    return array;
}


///Метод вывода массива Паскаля:
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int k = array.GetLength(0); k > i; k--)
            {
                Write("  ");
            }
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Write("{0,4}", array[i, j]);
            }
        WriteLine();
    }
}

int [,] array =  GetArray(numberRows);
WriteLine();

PrintArray(array);
