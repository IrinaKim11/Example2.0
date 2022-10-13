// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
// Находим квадрат числа
int sqr = number * number;
Console.WriteLine($"квадрат числа {number} равен {sqr}");
