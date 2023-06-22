// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int Prompt(string message)
{
    System.Console.Write($"{message} ");
    return int.Parse(Console.ReadLine());
}

int num = Prompt("Введите число: ");

int sum = 0;
while (num > 0)
{

    sum += num % 10;
    num = num / 10;

}
Console.WriteLine($"Сумма цифр введённого числа равна {sum}");
