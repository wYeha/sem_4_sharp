// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summ(int number)
{
    int result = 0;
    for (; number != 0; number = number / 10)
    {
        result += number % 10;
    }
    return result;
}

Console.Write("Введи число: ");
Console.WriteLine($"Сумма цифр в этом числе -> {Summ(Convert.ToInt32(Console.ReadLine()))}");