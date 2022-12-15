Console.Write("Введите размер строки - ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбца - ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];

void PrintArray (int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
}

FillArray(array);
Console.WriteLine();
PrintArray(array);