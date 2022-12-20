Console.Write("Введите размерность: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i < lenght; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int x = int.Parse(Console.ReadLine());
    if (x > 0) count++;
}
Console.WriteLine($"Чисел больше 0: {count}");