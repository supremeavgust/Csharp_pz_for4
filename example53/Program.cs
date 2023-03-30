// Задача 53: Задайте двумерный массив. Напишите 
// Программу, которая поменяет местами первую и последнюю 
// строку массива.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void TurnArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int x1 = matrix[0, j];
            int x = matrix[(matrix.GetLength(0) - 1), j];
            matrix[0, j] = x;
            matrix[(matrix.GetLength(0) - 1), j] = x1;

            Console.Write($"{matrix[i, j]} \t");

        }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int x1 = matrix[0, j];
            int x = matrix[(matrix.GetLength(0) - 1), j];
            matrix[0, j] = x;
            matrix[(matrix.GetLength(0) - 1), j] = x1;

            

        }
        Console.WriteLine();
    }

}
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
TurnArray(matrix);
