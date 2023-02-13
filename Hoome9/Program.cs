//Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int oneDigit = number / 100;
int twoDigit = (number / 100 * oneDigit) / 10;
int thirdDigit = number - 100 * oneDigit - 10 * twoDigit;
int newNumber = oneDigit * 10 + thirdDigit;
Console.WriteLine(newNumber);