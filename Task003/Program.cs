// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

int[,] matrix = new int[5, 5];
Random matrixX = new Random();

void ArrayRnd()
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrixX.Next(0, 100);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    return;
}

void MeanOfColumns()
{
    double[] sum = {0, 0, 0, 0, 0};

    for(int i = 0; i < 5; i++)
    {
        for(int j = 0; j < 5; j++)
        {
            sum[j] += matrix[i, j]; 
        }
    }

    Console.Write("Средние арифметические суммы столбцов массива: ");
    for(int k = 0; k < 5; k++)
    {
        Console.Write("{0} ", sum[k]/5);
    }
}

ArrayRnd();
Console.WriteLine();
MeanOfColumns();
