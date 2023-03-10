//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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



int m = ReadNumber("Введите кол-во строк");
int n = ReadNumber("Введите кол-во столбцов");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);

for(int j = 0; j < n; j++)
    {
        double aver_sum = 0;
        for(int i = 0; i < m; i++)
        {
            aver_sum += myMatrix[i, j];
           
        }
        Console.Write($"Среднее арифметическое столбца под индексом: {j} = {aver_sum / m}");
        Console.WriteLine();
    }




