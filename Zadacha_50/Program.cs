//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет



int stringMatrix = new Random().Next(1,11);
int columnMatrix = new Random().Next(1,11);

double [,] matrix = new double [stringMatrix,columnMatrix];

for (int i = 1; i < stringMatrix ; i++)
{
    for (int j = 1; j < columnMatrix; j++)
    {
        matrix[i,j] = new Random().NextDouble()*(10);
        Console.Write($"{Math.Round(matrix[i,j])}" + "\t");
           
    }
Console.WriteLine();
}

Console.WriteLine("Введите номер строки:");
int  x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int  y = Convert.ToInt32(Console.ReadLine());
if (x > stringMatrix || y > columnMatrix)
{
    Console.WriteLine("Данная позиция отсутствует!");
}
if (x < stringMatrix && y < columnMatrix)
{
    Console.Write("В данной позиции находится : ");
    Console.WriteLine($"{Math.Round(matrix[x,y])}");
}