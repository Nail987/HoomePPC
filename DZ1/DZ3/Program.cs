// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
int[,] CreateAndFillMatrix(int rows, int columns)
{
    int [,] matrix = new int [rows,columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = random.Next(-99,100);
        }
    }
    return matrix;
}
void PrintMatrix (int [,] matrix, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] >= 0)
                {
                   if (matrix[i,j] < 10) Console.Write($"  {matrix[i,j]} ");
                   else Console.Write($" {matrix[i,j]} ");
                }
            else
                {
                   if (matrix[i,j] > -10) Console.Write($" {matrix[i,j]} ");
                   else Console.Write($"{matrix[i,j]} ");
                }
        }
        Console.WriteLine();
    } 
}
void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int FindIndexMinInArray(int[] array)
{
    int min = array[0];
    int indexMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
            indexMin = i;
        }
    }
    return indexMin;
}
int FindMinRowSum(int [,] matrix)
{
    int sum = 0;
    int [] rowSum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        rowSum[i] = sum;
        sum = 0;
    }
    Console.WriteLine("Row sums: ");
    PrintArray(rowSum);
    return FindIndexMinInArray(rowSum);
}

int rows = ReadInt("Enter number of rows: ");
int columns = ReadInt("Enter number of columns: ");
if (rows == columns)
    Console.WriteLine("Please, enter different numbers of rows and columns. ");
else
{
    int [,] numbers = CreateAndFillMatrix(rows, columns);
    PrintMatrix(numbers, "Created matrix: ");
    Console.WriteLine($"\nRow #{FindMinRowSum(numbers)+1} has the lowest sum of elements.");
}
