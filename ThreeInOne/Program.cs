// Задайте двумерный массив размером m × n,
// заполненный случайными вещественными числами

Console.WriteLine("Здравствуйте!");

int rows = SetNumber("M");
int columns = SetNumber("N");
double[,] matrDoub = RanDoubleMatrix(rows, columns);
int[,] matrInt = GetNormalMatrix(rows, columns);
PrintDoubleMatrix(matrDoub);
PrintNormalMatrix(matrInt);
CheckIndMatr(matrInt);
FindMatrAvrg(matrInt);

int SetNumber(string text)
{
    Console.WriteLine($"Введите число {text}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[,] RanDoubleMatrix(int rows, int columns, int maxValue = 10, int minValue = 0)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1)
            + new Random().NextDouble();
        }
    }
    return matrix;
}

void PrintDoubleMatrix(double[,] matr)
{
    Console.WriteLine("Матрица вещественных готова");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} | ");
        }
        Console.WriteLine();
    }
}


// (изменено решением на семинаре) Напишите программу,
// которая на вход принимает значение элемента,
// а выдаёт индекс или указание на отсутствие элемента.

void CheckIndMatr(int[,] matr)
{
    Console.WriteLine("Укажите значение для получения индекса");
    string number = Console.ReadLine();
    int num = int.Parse(Console.ReadLine());
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (num == matr[i, j]) Console.WriteLine($"Индекс = ({i},{j})");
            else System.Console.WriteLine("Нет такого значения");
        }
    }
}



int[,] GetNormalMatrix(int rows, int columns, int maxValue = 10, int minValue = 10)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}



void PrintNormalMatrix(int[,] matr)
{
    Console.WriteLine("Матрица целочисленых готова");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} | ");
        }
        Console.WriteLine();
    }
}


// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

void FindMatrAvrg(int[,] matr)
{
    int sum = 0;
    int i = 0;
    int j = 0;
    for (; j < matr.GetLength(1); j++)
    {
        sum = sum + matr[i, j];
    }

    Console.WriteLine($"Среднее арифметическое столбца{j} = {sum}");
}