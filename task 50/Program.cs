// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] arr = new int[4,4];

Console.Write("Введите индекс столбца - ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов - ");
int x = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 0;
void array(int[,] arr) 
 {
    
    Console.WriteLine();
    for (i = 0 ; i < arr.GetLength(0); i++)
    {
       
      for (j = 0; j < arr.GetLength(1); j++)
     {
        arr[i,j] = new Random().Next(0, 10);
        Console.Write($"{arr[i,j]} ");
       
        
    }
    Console.WriteLine();
    }
    Console.WriteLine();
    if (x <= arr.GetLength(0) && y <= arr.GetLength(1)) Console.Write ( $" ({arr[i,j]})");
    else Console.Write("Такой позиции не существует");
 }

array(arr);




