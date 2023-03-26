// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

void InputArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(1, 100); // [-9, 9]
}


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        if (array[0] < array[1]+array[2] && array[1] < array[0]+array[2] &&array[2] < array[0]+array[1])
            Console.WriteLine("может существовать");
        else
        {
            Console.WriteLine("НЕможет существовать");
        }
        
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");