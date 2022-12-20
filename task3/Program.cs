Console.WriteLine("Введите размерность массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int sum = 0;
int i = 0;
int j = array.Length - 1;

for (i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (i = 0; i < array.Length / 2; i++)
{
    Console.Write(array[i] * array[j] + " ");
    sum = array[i] * array[j] + sum;
    j--;
}

Console.WriteLine();

Console.WriteLine("сумму произведений пар чисел " + sum);