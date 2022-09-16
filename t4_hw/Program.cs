/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/


Console.Clear();
Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.");
Console.WriteLine("Введите размерность X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность Z: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = new int[x, y, z];
FillArray3D(array3D);
PrintIndex(array3D);

void PrintIndex(int[,,] arr)// вывод индексов элементов 3D массива
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Функция заполнения 3D массива не повторяющимеся числами
void FillArray3D(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}


