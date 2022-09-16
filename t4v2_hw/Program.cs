/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/


Console.Clear();
Console.WriteLine("Задан трехмерный массив: ");
int[, ,] array3D = { { {62, 18}, {55, 29} }, { {92, 36}, {80, 13} } };
PrintArray3D(array3D);
Console.WriteLine($"\nВыведем массив построчно, добавляя индексы каждого элемента: ");
PrintIndex(array3D);

void PrintIndex(int[, ,] array3D)
{
  for(int i = 0; i < array3D.GetLength(0); i++) 
{
    for(int j = 0; j < array3D.GetLength(1); j++) 
    {
        for(int k = 0; k < array3D.GetLength(2); k++) 
        {
            Console.Write($"{array3D[i,j,k]}({i},{j},{k}) ");
        }
    }
    Console.WriteLine();
}
}
void PrintArray3D(int[, ,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
             for(int k = 0; k < array3D.GetLength(2); k++) 
             {
                Console.Write(array3D[i, j, k] + " ");
             }
        }
        Console.WriteLine("");
    }
}  

