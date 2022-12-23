// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y)

// всего есть 4 четверти

Console.WriteLine("Введите номер номер четверти, от 1 до 4");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 4 || number < 1)
{
    Console.WriteLine("Введенные данные не отвечают условию задачи");
}

if (number == 1)
{
    Console.WriteLine("x > 0; y > o");
}

if (number == 2)
{
    Console.WriteLine("x < 0; y > o");
}

if (number == 3)
{
    Console.WriteLine("x < 0; y < o");
}

if (number == 4)
{
    Console.WriteLine("x > 0; y < o");
}