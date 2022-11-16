Console.WriteLine("Программа, которая считает количество положительных чисел, введенных пользователем.");

Console.Write("Введите количество чисел: ");
int M = int.Parse(Console.ReadLine()!);

int CountPositiveNumbers()
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        int input = int.Parse(Console.ReadLine()!);
        if (input > 0) count++;
    }
    return count;
}
int result = CountPositiveNumbers();
Console.WriteLine("Количество положительных чисел: " + result);