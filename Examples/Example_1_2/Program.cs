Console.WriteLine("Определение челых чисел от -N до N");
Console.WriteLine("Введите целевое число, больше нуля:");

int number;
bool result = int.TryParse(Console.ReadLine(), out number);

if (!result || number < 0)
{
    Console.WriteLine("Введенные данные не являются числом, либо число меньше нуля");
}
else
{
    int invertNumber = - number;
    while (invertNumber <= number)
    {
        if (invertNumber < number)
        {
            Console.Write($"{invertNumber}, ");

        }
        else
        {
            Console.Write(invertNumber);

        }
        invertNumber++;
    }
}


//////////////// Остаток деления на 10
/*Console.WriteLine();
Console.WriteLine("Определение остатка от деления на 10 целого числа");
Console.WriteLine("Введите целевое число, больше 10");

int value;
bool result = int.TryParse(Console.ReadLine(), out value);

if (!result || value < 10)
{
    Console.WriteLine("Введенные данные не являются числом либо число меньше 10");
}
else
{
    Console.WriteLine($"Остаток от деления: {value % 10}");
}*/