//8 Дано число из отрезка [10, 99]. Показать наибольшую цифру числ
int m = 10;
int n = 99;
int max = 0;
int[] array = new int[n - m + 1];
for (int max[i] = 0; i < array.Length; i++)
{
    array[i] = m++;

}
Console.WriteLine(String.Join(",", array));