// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] mas = {{ 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }};

void PrintArray()
{
    int rows = mas.GetUpperBound(0) + 1;
    int columns = mas.Length / rows;
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{mas[i, j]} \t"); // \t - это табуляция или Tab или попросту 4 пробела
        }
        Console.WriteLine();
    }
}
PrintArray();

void ArrayElementQuery()
{
    Console.WriteLine("Введите строку в заданном массиве: ");
    string n = Console.ReadLine()!;
    Console.WriteLine("Введите столбец в заданном массиве: ");
    string m = Console.ReadLine()!;

    if((int.Parse(n) <= mas.GetLength(0)) && ((int.Parse(m) <= mas.GetLength(1))))
    {
        Console.WriteLine($"Есть такой элемент: {mas[int.Parse(n), int.Parse(m)]}");
    } 
    else
    {
        Console.WriteLine("Нет такого элемента!");
    }

}

ArrayElementQuery();
