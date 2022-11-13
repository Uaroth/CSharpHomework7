// 1) Задайте двумерный массив размером m × n,
// заполненный случайными вещественными числами
// 2) Изменено решением на семинаре: напишите программу,
// которая на вход принимает значение элемента,
// а выдаёт индекс или указание на отсутствие элемента.
// 3) Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

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
    Console.WriteLine();
}


void CheckIndMatr(int[,] matr)
{
    Console.WriteLine("Укажите значение для получения индекса");
    int num = int.Parse(Console.ReadLine());
    int numCount = 0; // Чтоб остановить после первого обнаружения и зафиксировать отсутствие
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (numCount == 0 && num == matr[i, j])
            {
                numCount++;
                Console.WriteLine($"Индекс = ({i},{j})");

            }
        }
    }
    if (numCount == 0) Console.WriteLine("Нет такого значения");
}


int[,] GetNormalMatrix(int rows, int columns, int maxValue = 10, int minValue = 0)
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
    Console.WriteLine("Матрица целочисленных готова");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} | ");
        }
        Console.WriteLine();
    }
}


void FindMatrAvrg(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {j} = {sum / matr.GetLength(0)}");
    }
}