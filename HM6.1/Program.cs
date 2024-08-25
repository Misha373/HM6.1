Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Прошграма 1: Обчислення середнього заробітку:");
Console.Write("Напишіть кількість працивників:");
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


Console.WriteLine("Прошграма 2: Побудова графіку зірочками:");
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