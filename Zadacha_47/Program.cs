//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Введите число строк:");
int  stringMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int  columnMatrix = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [stringMatrix,columnMatrix];

for (int i = 0; i < stringMatrix ; i++)
{
    for (int j = 0; j < columnMatrix; j++)
    {
        matrix[i,j] = new Random().NextDouble()*(10);
        Console.Write($"{Math.Round(matrix[i,j], 3)}" + "\t");
           
    }
    Console.WriteLine();
}
