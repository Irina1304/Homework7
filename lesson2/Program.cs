/*
Напишите программу, которая на вход принимает число и возвращает позицию (i, j) этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/



int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int m = ReadData("Введите количество строк в двумерном массиве: ");
int n = ReadData("Введите количество столбцов в двумерном массиве: ");

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(-9, 10);
        }
    }
    return array;
}

int number = ReadData("Введите проверяемое число: ");
int[,] RealArray = FillArray(m, n);
PrintArray(RealArray);

int count = 0;


for (int i = 0; i < RealArray.GetLength(0); i++)
{
    for (int j = 0; j < RealArray.GetLength(1); j++)
    {
        if (RealArray[i, j] == number)
        {
            Console.WriteLine($"Число {number} есть в данном массиве: строка {i + 1}, столбец {j + 1}");
        }
        else
        {
            count = count + 1;
        }
    }
}
if (count == RealArray.GetLength(0) * RealArray.GetLength(1))
{
    Console.WriteLine($"Числа {number} нет в данном массиве");
}




