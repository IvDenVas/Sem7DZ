// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int m = userInputCountRowsAndColumns("Введите количество строк: ", "Ошибка ввода!");
int n = userInputCountRowsAndColumns("Введите количество столбцов: ", "Ошибка ввода!");
int[,] array = GetArray(m, n, -50, 50);

PrintArray(array);

Console.Write($"Среднее арифметическое каждого столбца: ");

ArithmeticMeanRows(array);

void ArithmeticMeanRows(int[,] array)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        sum = Math.Round(sum / array.GetLongLength(0), 2);
        if ( j < array.GetLength(1) - 1)
            Console.Write($"{sum}; ");
        else Console.Write ($"{sum}.");
    }
}

int userInputCountRowsAndColumns (string message, string message1)//кол-во строк и столбцов строго от 1!!!
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
            if(num >= 1)
                return num;
        Console.WriteLine(message1);
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}