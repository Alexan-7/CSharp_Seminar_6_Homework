// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите любое количество целых чисел через пробел: ");
string line = Console.ReadLine ()!;
string[] parts = line.Split(' ');
int[] numbers = new int[parts.Length];          // перевести массив строк в массив чисел по [кол-ву в строке]

for (int i = 0; i < numbers.Length; i++)        // в новый массив положить элементы старого массива...
    numbers[i] = int.Parse(parts[i]);

int count = 0;
int zero = 0;

foreach (int value in numbers)
{
    if (value > 0)
        count++;
    else if (value == 0)
        zero++;
}

Console.WriteLine($"Кол-во положительных элементов: {count}, кол-во нулей: {zero}, ");
Console.WriteLine($"Кол-во отрицательных элементов: {numbers.Length - count - zero}");