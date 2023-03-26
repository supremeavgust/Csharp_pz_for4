// Задача 51. Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.))

int numb(string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void Random(int[,]arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(1,100);
        }
    }
}

void PrintArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
        Console.Write($"{arg[i, j]} ");
        }
    Console.WriteLine();
    }
}

int Summa(int [,]arg)
{
    int result = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
        if(i==j) result += arg[i,j];
        }
    }
    return result;
}

int rows = numb($"Введите длину строк: ");
int columns = numb ($"Введите длину столбцов: ");
int[,]Array = new int [rows, columns];
Random(Array);
PrintArray(Array);
Console.Write($"Сумма элементов на главной диагонали равна {Summa(Array)}");