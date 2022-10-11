/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintArray(double [ , ] numbers, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{numbers[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double [ , ] numbers, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers[i, j] = Math.Round (new Random().NextDouble() * 20 - 10, 1);
        }
    }
}

int m = ReadData("Введите количество строк в двумерном массиве: ");
int n = ReadData("Введите количество столбцов в двумерном массиве: ");

double [ , ] numbers = new double [m, n];

Console.WriteLine();
FillArray(numbers, m, n);
PrintArray(numbers, m, n);
