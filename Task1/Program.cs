// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
Clear();
Write("Ввдеите колличество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Write("Ввдеите колличество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new Double[m,n];
GetMatrixArray(m,n);
PrintMatrix(GetMatrixArray(m,n));

double[,] GetMatrixArray(int rows,int columns)
{
    double[,] resultMatrix = new double[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = new Random().Next(-20, 20);
        }
    }
    return resultMatrix;
}

void PrintMatrix(double[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{(inMatrix[i,j]/2.6):f1} ");    //Сорян, за такой способ))
        }
        WriteLine();
    }
}

double[] GetArrayFromString(string parameters)
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] parameterNum = new double[parames.Length];
    for(int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(parames[i]);
    }
    return parameterNum;
}
