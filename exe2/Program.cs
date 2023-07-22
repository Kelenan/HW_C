// Задача 2
Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine() ?? "";
int a = int.Parse(number1);
Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine() ?? "";
int b = int.Parse(number2);

if (a > b)
{
    Console.WriteLine($"max = {a}");
}
else 
{
    Console.WriteLine($"max = {b}");
}
