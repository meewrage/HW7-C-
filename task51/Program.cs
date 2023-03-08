//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12
int ReadNumber(string messageToUser)     //метод считывания целых чисел
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int colums, int leftBorder = 0, int rightBorder = 10) // создает матрицу
{
 
    int[,] matrix = new int[rows, colums];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder +1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)  // выводит матрицу на консоль
{
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

}

int SumOfPos(int[,] matrix)
{
    int sum = 0;
 for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
{
    if(i == j)
    {
    sum += matrix[i,j];
    }

}
}
return sum;
}

int m = ReadNumber("Введите кол-во строк");
int n = ReadNumber("Введите кол-во столбцов");
int[,] myMatrix = GetRandomMatrix(m, n);
int sum = SumOfPos(myMatrix);
PrintMatrix(myMatrix);
Console.WriteLine($"Сумма чисел на главной диагонали: {sum}");
