// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// task 35
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 124); // [0;123]
}


int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] >= 10 && array[i] <= 99)
            count ++;
    return count;
        
}


void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}


Console.Clear();
Console.Write($"n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
Console.WriteLine(ReleaseArray(array));