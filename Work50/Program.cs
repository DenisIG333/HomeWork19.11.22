

/* Задача 50. Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */
    

void RandomArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
}


void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int ReadUser(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int rows = ReadUser("Введите строку: ");
int colums = ReadUser("Введите столбец: ");
int[,] numbers = new int[7, 9];
RandomArray(numbers);
Print(numbers);


if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1))
{
    Console.WriteLine($" Значение элемента -> {numbers[rows, colums]}");
}
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");