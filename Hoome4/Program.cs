// //Выяснить является ли число чётным
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
a=a%2;
if (a==0)
{
    Console.WriteLine("Ваше число четное: "+a);
} 
else 
Console.WriteLine("Ваше число нечетное: "+a);