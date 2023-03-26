// второй максиум
Console.Clear();

int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// "5 4 3 2"
// "5", "4", "3", "2"
// 5, 4, 3, 2
// [5, 4, 3, 2]
Console.WriteLine($"[{string.Join(", ", array)}]");

foreach (int elem in array)
    Console.WriteLine(elem * 100);