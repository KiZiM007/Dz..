// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] Metod(int num)
{
    int[] mass = new int[num];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(0, 100);
    }
    return mass;
}
int[] massiv = Metod(number);
void Metod2(int[] massiv1)
{
    Console.Write("[");
    for (int i = 0; i < massiv1.Length; i++)
    {
        Console.Write($" {massiv1[i]} ");
    }
    Console.Write("]");
}
Metod2(massiv);