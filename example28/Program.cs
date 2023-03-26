// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120.

// int f(int n)
// {
//     int b = 1;
//     int count = 1;
//     while (count <= n)
//     {
//         b = b * count;
//         count++;

//     }
// return b;
// }

// Console.Clear();
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(a));


int f(int n)
{
    int res = 1;
    for(int i=2; i<=n; i++)
    res*=i;
return res;
}

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a));
