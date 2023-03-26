// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = new double[8];

for (int i = 0; i < array.Length; i++)  // * (end - begin) + begin
    array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2);  //[10; 50]


double max1 = array[0];
double min1 = array[0];

for (int i = 0; i < array.Length; i++) 
{
    if (array[i] > max1)
        max1 = array[i];
    if (array[i] < min1)
        min1 = array[i];
}

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(max1 - min1);