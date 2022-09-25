//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Введите позицию элемента по оси строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента по оси столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[3,4];

FillArray(matrix);
PrintArray(matrix);

if (rows < matrix.GetLength(0) && columns < matrix.GetLength(1)) 
{
    Console.WriteLine(matrix[rows, columns]);
}
else 
{
    Console.WriteLine("такого числа в массиве нет");
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}