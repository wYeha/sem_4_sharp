// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Power(int number, int power)
{
    double result = number;
    if (power == 0) return 1;
    if (power > 0)
    {
        for (int i = 1; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
    if (power < 0)
    {
        for (int i = -1; i > power; i--)
        {
           result *= number;
        }
        return 1/result;
    }
    else return -1;
}

Console.WriteLine("Введи число, затем введи степень этого числа, через Enter: ");

Console.WriteLine($"Результат возвездения в степень -> {Power(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()))}");