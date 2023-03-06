/* Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
int[,] CreateAndFill2DArray(int rows, int columns)
{
    int [,] array = new int [rows,columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }
    return array;
}
void Print2DArray (int [,] matrix, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < 10)
                Console.Write($"   {matrix[i,j]} ");
            else if (matrix[i,j] < 100)
                Console.Write($"  {matrix[i,j]} ");
            else
                Console.Write($" {matrix[i,j]} ");
        }
        Console.WriteLine();
    } 
}

int [,] MultipliedMatrix (int[,] tableA, int[,] tableB)
{
    int sum = 0;
    int[,]result = new int[tableB.GetLength(1), tableA.GetLength(0)];
    for (int i = 0; i < tableB.GetLength(1); i++)
    {
        for (int k = 0; k < tableA.GetLength(0); k++)
        {
            for (int j = 0; j < tableA.GetLength(1); j++)
            {
              sum += tableA[i,j] * tableB[j,k]; 
            }
            result[i,k] = sum;
            sum = 0;
        }
    }
    return result;
}

int rows = ReadInt("Enter number of rows: ");
int columns = ReadInt("Enter number of columns: ");
int [,] matrixA = CreateAndFill2DArray(rows, columns);
int [,] matrixB = CreateAndFill2DArray(columns, rows);
Print2DArray(matrixA, "Created matrix A: ");
Print2DArray(matrixB, "Created matrix B: ");
Print2DArray(MultipliedMatrix(matrixA,matrixB), "Multiplied matrix: ");