// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

using static System.Console;
Clear();
Write("Ввдеите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
WriteLine();
double[] res = Arithmetic(matrix);
Write("Среднее арифметическое каждого столбца: ");
PrintArray(res);

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

void PrintArray(double[] array) 
{
    Console.Write(" ");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(" ");
}

double[] Arithmetic(int[,] matr)
{
    double[] result = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)  
        {
            sum = sum + matr[i, j];
        } 
        result[j] = Math.Round((sum / matr.GetLength(0)), 1);
    }
    return result;
}


