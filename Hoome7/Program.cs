//Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int c;
while (number >= 100)
{
    number = number / 10;
}
c = number % 10;
Console.WriteLine("Второе число: " + c);
