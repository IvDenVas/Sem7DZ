// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Clear();

int m = userInputCountRowsAndColumns("Введите количество строк: ", "Ошибка ввода!");
int n = userInputCountRowsAndColumns("Введите количество столбцов: ", "Ошибка ввода!");

int[,] array = GetArray(m, n, -50, 50);

int positionX = userInputIndexElement("Введите первую позицию элемента: ", "Ошибка ввода!");
int positionY = userInputIndexElement("Введите введите вторую позицию элемента: ", "Ошибка ввода!");

PrintArray(array);
OutputResult(array, positionX, positionY);

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

int userInputIndexElement (string message, string message1)//индексы строго от 0!!!
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
            if(num >= 0)
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

void OutputResult(int[,] array, int x, int y)
{
    if ( x + 1 > array.GetLength(0) | y + 1 > array.GetLength(1))
        Console.Write(" -> такого числа в массиве нет");
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                if (i == x  && j == y) Console.WriteLine($" -> {array[i,j]}");
    }
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