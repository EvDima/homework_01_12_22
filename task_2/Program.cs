// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array = new int[rows, cols];
GetArray(array);
PrintArray(array);
Console.WriteLine();
SumMinRowArray(array);
PrintArray(array);



void GetArray(int[,]  inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void SumMinRowArray(int[,] inArray)
{
    int sum = 0;
    int indexLine = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)  
        {
            sum += array[i, j];
        }
        if(sum < minSum)
        {
            minSum = sum;
            indexLine = i;
        }
        sum = 0;    
    }
    Console.WriteLine($"Строка с наименьшей суммой елементов под номером: {indexLine + 1} , с суммой элементов равной: {minSum} ");
}
