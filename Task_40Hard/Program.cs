Console.WriteLine("Программа, которая определяет, существует ли треугольник и выводит всю информацию по нему");

Console.WriteLine("Введите длины сторон треугольника: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

bool Triangle(int a, int b, int c)
{
    bool check = false;
    if (a < b + c && b < a + c && c < a + b)
    {
        check = true;
    }
    return check;
}
bool result = Triangle(a, b, c);
if (result)
{
    Console.WriteLine("Треугольник существует.");

    int perimeter = GetPerimeter(a, b, c);
    Console.WriteLine("Периметр треугольника: " + perimeter);

    double square = GetSquare(a, b, c);
    Console.WriteLine("Площадь треугольника: " + square);

    double firstAngle = Math.Acos((double)(b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
    double secondAngle = Math.Acos((double)(a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
    double thirdAngle = Math.Acos((double)(a * a + b * b - c * c) / (2 * b * a)) * 180 / Math.PI;

    Console.WriteLine("Первый угол треугольника: " + Math.Round(firstAngle, 2) + '°');
    Console.WriteLine("Второй угол треугольника: " + Math.Round(secondAngle, 2) + '°');
    Console.WriteLine("Третий угол треугольника: " + Math.Round(thirdAngle, 2) + '°');

    if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b) Console.WriteLine("Треугольник прямоугольный.");
    else if (a == b && b == c) Console.WriteLine("Треугольник равносторонний.");
    else if (a == b || b == c || a == c) Console.WriteLine("Треугольник равнобедренынй.");
    else Console.WriteLine("Треугольник произвольный.");
}
else Console.WriteLine("Треугольник не существует.");



int GetPerimeter(int a, int b, int c)
{
    int perimeter = a + b + c;
    return perimeter;
}

double GetSquare(int a, int b, int c)
{
    double halfPerimeter = (double)GetPerimeter(a, b, c) / 2;
    double temp = halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c);
    double square = Math.Sqrt(temp);
    return Math.Round(square, 2);
}

