Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Програма 1: Обчислення середнього заробітку:");
Console.Write("Напишіть кількість працивників:");


try
{
    int workersnumber = int.Parse(Console.ReadLine());

    decimal TotalSalary = 0;

    for (int i = 0; i < workersnumber; i++)
    {
        Console.Write($"Скільки заробляє працівник {i + 1}:");
        decimal salary = int.Parse(Console.ReadLine());
        TotalSalary += salary;
    }

    decimal AverageSalary = TotalSalary / workersnumber;

    Console.WriteLine($"Середня зарпалата {workersnumber} робітників, сягає - {AverageSalary}");
}
catch (Exception)
{
    Console.WriteLine("Введений вираз не має змісту");
}
Console.WriteLine();
Console.WriteLine("Програма 2: Побудова графіку зірочками:");

try
{
    Console.Write("Напишіть кількість рядків графіку:");
    int numberline = int.Parse(Console.ReadLine());

    for (int i = 1; i <= numberline; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
catch (Exception)
{
    Console.WriteLine("Введений вираз не має змісту");
}
Console.WriteLine();

Console.WriteLine("Програма 3: Генерація простих чисел:");
try
{
    Console.Write("Напишіть число до якого знаходити прості числа:");
    int limitnumbers = int.Parse(Console.ReadLine());
    if (limitnumbers <= 1)
    {
        Console.WriteLine("Просте число не може бути рівне 1 або меньшому числу");
    }
    else
    {
        for (int i = 2; i < limitnumbers; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.Write(i + " ");
            }

        }
    }
}
catch (Exception)
{
    Console.WriteLine("Введений вираз не має змісту");
}
Console.WriteLine();

Console.WriteLine("Програма 5: Генерація фібоначчівської послідовності:");
Console.Write("Напишіть яку кількість чисел Фібаначі знайти:");
int N = int.Parse(Console.ReadLine());

try
{
    if (N < 1)
    {
        Console.WriteLine("Кількість числел Фібаначі повинна бути більше або дорівнювати 1");
    }
    else
    {
        int a = 0;
        int b = 1;
        int c = 0;



        for (int i = 1; i <= N; i++)
        {
            Console.Write(c + " ");
            c = a + b;
            a = b;
            b = c;
        }


    }
}
catch (Exception)
{
    Console.WriteLine("Введений вираз не має змісту");
}
Console.WriteLine();

Console.WriteLine("Програма 6: Калькулятор оплати праці за годину:");

try
{
    Console.Write("Напишіть кількість годин працьованих за день:");
    int hours = int.Parse(Console.ReadLine());

    if (hours > 24)
    {
        Console.WriteLine("Кількість годин за добу не може бути більше 24");
    }
    else if (hours <= 0)
    {
        Console.WriteLine("Кількість годин повинно бути быльше 0");
    }
    else
    {
        Console.Write("Напишіть оплату за годину:");
        int HourlyPay = int.Parse(Console.ReadLine());

        Console.WriteLine($"Зарплата за день буде сягати: {HourlyPay * hours}");
    }
}
catch (Exception)
{
    Console.WriteLine("Введений вираз не має змісту");
}
Console.WriteLine();

Console.WriteLine("Програма 7: Генерація таблиці множення для конкретного числа:");


try
{
    Console.Write("Напишіть число з яким утворити таблицю множення від 1 до 10:");
    int Number = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{Number}x{i}={Number * i}");
    }
}
catch (Exception)
{
    Console.WriteLine("Введений вираз не має змісту");
}
Console.WriteLine();

Console.WriteLine("Програма 8: Перевірка на простоту:");


try
{
    Console.Write("Напишіть число яке хочете перевірити на простоту:");
    int Prime = int.Parse(Console.ReadLine());
    bool issPrime = false;
    if (Prime <= 1)
    {
        Console.WriteLine("Просте число не може бути рівне 1 або меньшому числу");
    }
    if (Prime == 2)
    {
        Console.WriteLine($"Число {Prime} є простим числом");
    }
    if (Prime == 3)
    {
        Console.WriteLine($"Число {Prime} є простим числом");
    }

    else
    {
        for (int i = 2; i < Prime; i++)
        {
            issPrime = true;
            if (Prime % i == 0)
            {
                Console.WriteLine($"Число {Prime} не є простим числом");
                issPrime = false;
                break;
            }

        }
        if (issPrime)
        {
            Console.WriteLine($"Число {Prime} є простим числом");
        }
    }
}
catch (Exception)
{
    Console.WriteLine("Введений вираз не має змісту");
}
Console.WriteLine();