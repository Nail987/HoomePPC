// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Clear();
Console.WriteLine();

int QuarterNumber = 0;
int x = new Random().Next(-100, 101);
int y = new Random().Next(-100, 101);
Console.WriteLine($"Координаты точки: ({x}, {y})");

if (x * y == 0) QuarterNumber = 0;
else if (x > 0 && y > 0) QuarterNumber = 1;
else if (x < 0 && y > 0) QuarterNumber = 2;
else if (x < 0 && y < 0) QuarterNumber = 3;
else QuarterNumber = 4;

Console.Write($"Точка с координатами ({x}, {y}) находится ");
if (QuarterNumber == 0)Console.WriteLine("на одной из оси координат");
else Console.WriteLine($"в {QuarterNumber}-й четверти");
Console.WriteLine();