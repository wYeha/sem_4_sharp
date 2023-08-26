// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power(int number, int power)
{
    int result = number;
    for (int i = 1; i < power; i++)
    {
        result *= number;
    }
    return result;
}

Console.WriteLine("Введи число, затем введи степень этого числа, через Enter: ");

Console.WriteLine($"Результат возвездения в степень -> {Power(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()))}");