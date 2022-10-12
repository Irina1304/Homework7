/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/



int m = ReadData("Введите количество строк в двумерном массиве: ");
int n = ReadData("Введите количество столбцов в двумерном массиве: ");

double[,] matrix = new double[m, n];
double[] avgNumbers = new double[matrix.GetLength(1)];

FillMatr(matrix);
Console.WriteLine();
PrintMatr(matrix);


int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintMatr(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
    }
}

void FillMatr(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


for (int i = 0; i < matrix.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        result += matrix[j, i];
    }
    avgNumbers[i] = result / matrix.GetLength(0);
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i].ToString("0.00") + "; ");
    }
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(avgNumbers);