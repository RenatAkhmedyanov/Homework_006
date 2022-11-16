Console.WriteLine("Программа, которая выводит минимальное число и его индекс, максимальное число и его индекс, среднее арифметическое элементов двумерного массива.");

Console.Write("Введите число строк таблицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов таблицы: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(m, n);
PrintArray(array);

GetMin(array);

GetMax(array);

double average = GetAverage(array, m, n);
Console.WriteLine("Среднее арифметическое элементов массива: " + Math.Round(average, 2));



int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-100, 101);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}", array[i, j]));
        }
        Console.WriteLine();
    }
}

void GetMin(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
    Console.WriteLine($"Минимальное значение {min}");
    Console.WriteLine($"Индекс минимального значения [{minI}, {minJ}]");
}

void GetMax(int[,] array)
{
    int maxI = 0;
    int maxJ = 0;
    int max = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
                maxI = i;
                maxJ = j;
            }
        }
    }
    Console.WriteLine($"Максимальное значение {max}");
    Console.WriteLine($"Индекс максимального значения [{maxI}, {maxJ}]");
}

double GetAverage(int[,] array, int m, int n)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
    }
    double average = (double)sum / (m * n);
    return average;
}




