/* 
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
*/

Console.WriteLine("количество строк");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("количество столбцов");
int m = int.Parse(Console.ReadLine());

int[,] numbers = new int[n, m];
RandomArray(numbers);
Console.WriteLine();

Print(numbers);
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = avarage + numbers[i, j];
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}


void RandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
      
        Console.WriteLine("");
    }
}


