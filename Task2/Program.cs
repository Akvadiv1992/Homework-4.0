Console.Clear();
Console.Write("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0, d;

while (a != 0)
{    
    d = a % 10;
    a = a / 10;
    sum = sum + d;
}

Console.WriteLine($"Сумма цифр ровна: {sum}");
