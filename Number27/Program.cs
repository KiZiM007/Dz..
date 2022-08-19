// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Metod(int number)
{
    int col = 0;
    while (number > 0)
    {
        int lastnumber = number % 10;
        number = number / 10;
        col = col + lastnumber;
    }
    return col;
}
int result = Metod(num);
Console.Write($"Сумма цифр в числе {num} -> {result}");