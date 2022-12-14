// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
double[,] generateTwodimensionalArray(int height, int width, int randomStart, int randomEnd)
{
    double[,] twodimensionalArray = new double [height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twodimensionalArray[i, j] = new Random().NextDouble() * 10;
        }
    }
    return twodimensionalArray;
}

void print2DArray(double[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(Math.Round(arrayToPrint[i, j],1) + "\t");
        }
        Console.WriteLine();
    }
}

double[,] generateArray = generateTwodimensionalArray(3, 4, -10, 10);
print2DArray(generateArray);