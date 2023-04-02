// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


void FillArray(int [,] array)
{
    for (int i = 0;i< array.GetLength(0);i++)
    {
        for (int j = 0;j<array.GetLength(0);j++ )
        {
            array[i,j] = new Random().Next(-30,30);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(0);j++)
        {
            Console.Write($"{array[i,j],3} \t");
        
        }
        Console.WriteLine();
    }
}





Console.WriteLine("Введите колтичество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);