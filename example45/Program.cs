// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] arr = { 0, 1, 2, 3 };
            int[] arr0; Array.Copy(arr, arr0 = new int[arr.Length], arr.Length);

Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine($"[{string.Join(", ", arr0)}]");