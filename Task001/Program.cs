// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.WriteLine("Введите кол-во m-строк массива: ");
string m = Console.ReadLine()!;
Console.WriteLine("Введите кол-во n-столбцов массива: ");
string n = Console.ReadLine()!;

void ArrayFilling()
{
    double[,] matrix = new double[int.Parse(m), int.Parse(n)];
    Random matrixX = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrixX.Next(-1000, 1000);
            Console.Write($"{(matrix[i, j]/10)} ");
        }
        Console.WriteLine();
    }
    
}
ArrayFilling();