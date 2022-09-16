/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();
Console.WriteLine($"Задайте две матрицы. \nНапишите программу, которая будет находить произведение двух матриц.");

Console.WriteLine("Введите количество строк матрицы А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы А: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] arrayA = new int[a, b];
FillArray(arrayA);
Console.WriteLine("Получена матрица А: ");
PrintArray(arrayA);
Console.WriteLine();

Console.WriteLine("Введите количество строк матрицы B: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы B: ");
int d = Convert.ToInt32(Console.ReadLine());
int[,] arrayB = new int[c, d];
FillArray(arrayB);
Console.WriteLine("Получена матрица B: ");
PrintArray(arrayB);

int[,] arrayC = new int[a, d];

if (b != c)
{
    Console.WriteLine($"\nПолученные матрицы умножить друг на друга нельзя: матрицу А можно умножить на матрицу В, только если число её столбцов равно числу строк матрицы В.");
}
else
{
ArrayProduct(arrayA, arrayB, arrayC);
Console.WriteLine($"\nПроизведение матрицы А на матрицу В:");
PrintArray(arrayC);
}
void ArrayProduct(int[,] arrayA, int[,] arrayB, int[,] arrayC)
{
  for (int i = 0; i < arrayC.GetLength(0); i++)
  {
    for (int j = 0; j < arrayC.GetLength(1); j++)
    {
      int result = 0;
      for (int k = 0; k < arrayA.GetLength(1); k++)
      {
        result += arrayA[i,k] * arrayB[k,j];
      }
      arrayC[i,j] = result;
    }
  }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

