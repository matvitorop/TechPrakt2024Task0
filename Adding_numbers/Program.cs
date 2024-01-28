Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введіть перше число:");

if (double.TryParse(Console.ReadLine(), out double number1))
{
    Console.WriteLine("Введіть друге число:");
    if (double.TryParse(Console.ReadLine(), out double number2))
    {
        double sum = number1 + number2;
        Console.WriteLine($"Сума чисел {number1} і {number2} дорівнює: {sum}");
    }
    else
    {
        Console.WriteLine("Невірний формат другого числа.");
    }
}
else
{
    Console.WriteLine("Невірний формат першого числа.");
}
