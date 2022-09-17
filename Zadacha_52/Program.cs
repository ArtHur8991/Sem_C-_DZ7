//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.





int stringMatrix = new Random().Next(1,11);
int columnMatrix = new Random().Next(1,11);

int [,] matrix = new int [stringMatrix,columnMatrix];

for (int i = 0; i < stringMatrix ; i++)
{
    for (int j = 0; j < columnMatrix; j++)
    {
        matrix[i,j] = new Random().Next(1,11);
        Console.Write($"{matrix[i,j]}" + "\t");
           
    }
    Console.WriteLine();
}

Console.WriteLine("среднеарефмитическое значение в каждом столбце");

for (int j = 0; j < columnMatrix; j++)
{
    double average =0;
    for(int i = 0; i < stringMatrix; i++ )
{
         average += matrix[i,j];
    
}
    Console.Write($"{average/stringMatrix}" + "\t");
}