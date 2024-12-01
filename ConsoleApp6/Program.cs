Console.Write("Введите количество строк M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов N: ");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];
Console.WriteLine("Введите элементы матрицы (целые числа):");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"Элемент [{i + 1}, {j + 1}]: ");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int j = 0; j < n; j++)
{
    int[] column = new int[m];
    for (int i = 0; i < m; i++)
    {
        column[i] = matrix[i, j];
    }
    if (j % 2 == 0)
    {
        Array.Sort(column);
    }
    else
    {
        Array.Sort(column);
        Array.Reverse(column);
    }
    for (int i = 0; i < m; i++)
    {
        matrix[i, j] = column[i];
    }
}
Console.WriteLine("Отсортированная матрица:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}