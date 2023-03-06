// Показать двумерный массив размером m×n заполненный вещественными числами
void PrintArray (double[] array, string text)
    {
        Console.Write(text);
        for (int i = 0; i < array.Length; i++)
            Console.Write($"{array[i]} ");
        Console.WriteLine();
    } 
int ReadInt(string text)
    {
        Console.WriteLine(text);
        return int.Parse(Console.ReadLine()!);
    }

void FillArray (double [,] array, int k)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                array[i,j] = Math.Round(rnd.NextDouble()*double.Parse(k.ToString()),2);
        }
    }

void Print2DArray(double [,] array, string text)
    {
        Console.WriteLine("\n");
        Console.WriteLine(text);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                if (array[i,j] >= 0)
                    Console.Write($" {array[i,j]} \t");
                else
                    Console.Write($"{array[i,j]} \t");
        Console.WriteLine();
        }
    }




int m = ReadInt("Enter a number of rows: ");
int n = ReadInt("Enter a number of columns: ");
int k = ReadInt("Enter a limit of numbers: ");
double [,] numbers = new double [m,n];

 
FillArray(numbers,k);
Print2DArray(numbers, "Array: ");