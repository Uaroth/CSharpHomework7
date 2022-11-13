// Задайте двумерный массив размером m × n,
// заполненный случайными вещественными числами

Console.WriteLine("Здравствуйте!");

int rows = SetNumber("M");
int columns = SetNumber("N");
double [,] matrix = RanDoubleMatrix(rows, columns);
PrintArray(matrix);



int SetNumber(string text)
{
    string[] arr = text.Split(" ");
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

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} | ");
        }
        Console.WriteLine();
    }
}
