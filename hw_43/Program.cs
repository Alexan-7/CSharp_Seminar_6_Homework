// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Программа найдёт точку пересечения двух прямых, заданных их уравнениями");
Console.Write("Введите k1: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double d = Convert.ToDouble(Console.ReadLine());

CheckingLines(a, b, c, d);

void CheckingLines(double a, double b, double c, double d)
{
    if (a * c == -1)
        Console.WriteLine("Ваши прямые перпендикулярны");
    else if (a == c && b == d)
        Console.WriteLine("Прямые совпадают");
    else if (a == c)
        Console.WriteLine("Точек пересечения нет, прямые параллельны");
    else
    {
        double x = (d - b) / (a - c);   // чем уже видимость переменной,...
        double y = a * x + b;           // ...тем меньше ошибок с ней
        Console.WriteLine($"Абсцисса точки пересечения прямых: {x}, её ордината: {y}");
    }
}

