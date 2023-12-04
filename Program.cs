// Заполните спирально массив 4 на 4.
Console.Clear();
int n = 4;
int[,] array = new int[n, n];


int count = 1;
int i = 0;
int j = 0;

while (count <= array.GetLength(0) * array.GetLength(1))
{
    array[i, j] = count;
    count++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
    else if (i < j && i + j >= array.GetLength(0) -1) i++;
    else if (i >= j && i + j > array.GetLength(1)-1) j--;
    else i--;
}
PrintArray(array);
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
             if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }

}
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int rows = UserNumber("Введите количество строк в массиве: ", "Ошибка ввода! ");
int columns = UserNumber("Введите количество столбцов в массиве: ", "Ошибка ввода! ");
int maxValue = UserNumber("Введите значение от 0 до: ", "Ошибка ввода! ");
int[,] array = GetArray(rows, columns, 0, maxValue);
PrintArray(array);
BubbleSort(array);
Console.WriteLine();
PrintArray(array);

int UserNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.Write(errormessage);

    }
}
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

}
void BubbleSort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
    }
}

// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int rows = UserNumber("Введите количество строк массива: ", "Ошибка ввода! ");
int columns = UserNumber("Введите количество столбцов массива: ", "Ошибка ввода! ");
int maxValue = UserNumber("Введите максимальное значение от 0 до: ", "Ошибка ввода! ");
int[,] array = CreateArray(rows, columns, 0, maxValue);
PrintArray(array);
int sumLine = SumElements(array, 0);
int minSum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int minSumLine = SumElements(array, i);
    if (sumLine>minSumLine)
    {
        sumLine = minSumLine;
        minSum = i;
    }
}
Console.WriteLine($"{minSum+1} - это строка с наименьшей суммой, в которой {sumLine-1} элементов");

int UserNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.Write(errormessage);
    }
}

int[,] CreateArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;

}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    
}

int SumElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumLine += array[i,j];
    }
    return sumLine;
}

// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

Console.Clear();
int rows1 = UserNumber("Введите число строк 1-й матрицы: ", "Ошибка ввода! ");
int columns1rows2 = UserNumber("Введите число столбцов 1-й матрицы (и строк 2-й):  ", "Ошибка ввода! ");
int columns2 = UserNumber("Введите число столбцов 2-й матрицы: ", "Ошибка ввода! ");
int maxValue = UserNumber("Введите максимальное значение от 0 до: ", "Ошибка ввода! ");
int[,] firstArray = CreateArray(rows1, columns1rows2, 0, maxValue);
Console.WriteLine();
Console.WriteLine($"Первая матрица:");
PrintArray(firstArray);
Console.WriteLine();
int[,] secondArray = CreateArray(columns1rows2, columns2, 0, maxValue);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondArray);
int[,] resultMatrix = new int [rows1, columns2];
MultiplayerMatrix(firstArray, secondArray, resultMatrix);
Console.WriteLine($"Итоговая матрица с произведениями матрица:");
PrintArray(resultMatrix);

void MultiplayerMatrix(int [,] firstArray, int[,] secondArray, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum+= firstArray[i,k]*secondArray[k,j];
            }
            resultMatrix[i,j] = sum;
        }
    }
}

int UserNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.Write(errormessage);
    }

}

int[,] CreateArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

// // Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
int rows = UserNumber("Введите количество строк в массиве: ", "Ошибка ввода! ");
int columns = UserNumber("Введите количество столбцов в массиве: ", "Ошибка ввода! ");
int depth = UserNumber("Введите количество глубины в массиве: ", "Ошибка ввода! ");
int maxValue = UserNumber("Введите значение от 0 до: ", "Ошибка ввода! ");
int[,,] array = new int[rows, columns, depth];
CreateArray(array);
PrintArray(array);


int UserNumber(string message, string errormessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
        return num;
        Console.Write(errormessage);
    }
}

void CreateArray(int[, ,] array)
{
   {
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
}
void PrintArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
