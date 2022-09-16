/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


Console.WriteLine($"Задайте прямоугольный двумерный массив. \nНапишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
int minSum = Int32.MaxValue;
int rowNumber = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum > minSum)
    {
        rowNumber++;
        Console.WriteLine($"Cумма элементов строки №{rowNumber} равна {sum}"); 
        //без >, а только с < программа не показывает сумму всех строк, а лишь до момента, когда находит minSum (а он может быть и в первой строке)
    }
    if (sum < minSum)
    {
        minSum = sum;
        rowNumber++;
        Console.WriteLine($"Cумма элементов строки №{rowNumber} равна {sum}");
    }
}
Console.WriteLine($"Наименьшая сумма элементов, равная {minSum}, в строке №{rowNumber}.");
return minSum;

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
