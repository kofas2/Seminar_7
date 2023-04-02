// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// и отдельно сумму элементов обратной диагонали.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12
// Сумма элементов обратной диагонали: 8+9+7 = 24


void FillArray(int [,] array)
{
    for (int i = 0;i< array.GetLength(0);i++)
    {
        for (int j = 0;j<array.GetLength(0);j++ )
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(0);j++)
        {
            Console.Write($"{array[i,j],2}\t");
        
        }
        Console.WriteLine();
    }
}

int SumDiagonal1(int [,]array)
{
    int sum1 = 0;
    for (int i = 0;i< array.GetLength(0);i++)
    {
        for (int j = 0;j<array.GetLength(0);j++ )
        {
            if (i==j)
            {
                sum1 += array[i,j];
            }                           
        }
    }
    return sum1;
}

int SumDiagonal2(int [,]array)
{
    int sum2 = 0;
    for (int i = 0;i< array.GetLength(0);i++)
    {
        for (int j = 0;j<array.GetLength(0);j++ )
        {
            if (array.GetLength(0)-1-i==j)
            {
                sum2 += array[i,j];
            }                           
        }
    }
    return sum2;
}



int [,] array = new int [4,4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива по главной диагонали равна {SumDiagonal1(array)}");
Console.WriteLine($"Сумма элементов массива по обратной диагонали равна {SumDiagonal2(array)}");