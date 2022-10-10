// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static System.Console;
Clear();
Write("Ввдеите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
WriteLine();
Write("Введите индекс числа в строке: ");
int M = int.Parse(ReadLine()!);
Write("Введите индекс числа в столбце: ");
int N = int.Parse(ReadLine()!);
Write("Введите искомое число: ");
int Found = int.Parse(ReadLine()!);
int SearchNum = SearchNumber(matrix, M, N);

if (SearchNum==Found)
{
    WriteLine($"Число есть по данным координатам");
    return;
}
else
{
    WriteLine($"Числа по данным координатам нет");
}

int[,] GetMatrixArray(int rows,int columns,int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j]=new Random().Next(minValue,maxValue+1);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j]} ");
        }
        WriteLine();
    }
}

int[] GetArrayFromString(string parameters)
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parameterNum = new int[parames.Length];
    for(int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(parames[i]);
    }
    return parameterNum;
}

int SearchNumber(int[,] INMatrix, int m, int n)
{
    int result = 0;
    for (int i = 0; i < INMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < INMatrix.GetLength(1); j++)
        {
           result = INMatrix[m,n];
        }
    }
    return result;
}




