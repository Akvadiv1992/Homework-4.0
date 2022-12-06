Console.Clear();

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень B: ");
int b = Convert.ToInt32(Console.ReadLine());

{
int result = 1;
for (int i = 1; i <= b; i++)

    {
        result = result * a;
    }
    Console.WriteLine($"Число {a} в степени {b}: {result}");
}
