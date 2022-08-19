// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Ввелите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Ввелите степень числа {num1}: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Metod(int number1, int number2)
{
    int result = number1;
    for (int i = 1; i < number2; i++)
    {
        result = result * number1;
    }
    return result;
}
int otvet = Metod(num1, num2);
Console.Write($"{num1} в степени {num2} = {otvet}");