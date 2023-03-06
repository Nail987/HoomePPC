/*
Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая
будет построчно выводить массив, добавляя
индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
bool DoesNumberAlreadyExists(int lookFor, int[,,] matrix)
{
    bool flag = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                if (matrix[i, k, j] == lookFor)
                    flag = true;
            }
        }
    }
    return flag;
}
int[,,] CreateAndFill3DArray(int x, int y, int z)
{
    int temp = 0;
    bool flag = false;
    int[,,] matrix = new int[x, y, z];
    Random random = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                flag = false;
                while (!flag)
                {
                    temp = random.Next(10, 100);
                    if (!DoesNumberAlreadyExists(temp, matrix))
                    {
                        matrix[i, j, k] = temp;
                        flag = true;
                    }
                }
            }
        }
    }
    return matrix;
}
void Print3DArray(int[,,] matrix, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($" {matrix[i, j, k]} ({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int x = ReadInt("Enter number of x: ");
int y = ReadInt("Enter number of y: ");
int z = ReadInt("Enter number of z: ");
int[,,] matrix = CreateAndFill3DArray(x, y, z);

Print3DArray(matrix, "Created matrix: ");