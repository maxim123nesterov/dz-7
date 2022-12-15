// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите размер строки - ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбца - ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
int avrg = 0;
int sum = 0;
int count = 0;


/*void PrintArray (int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}*/


{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
        if (i < array.GetLength(0))
        {
            sum = sum + array[i];
            count = count + 1;
            avrg = sum / count;
            Console.Write(avrg);
        }
    }
}


//PrintArray(array);

