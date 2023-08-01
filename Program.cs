// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] GetMatrix (int m, int n, - 999, 999)
// {
// double [,] matrix = new double [m, n] ;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); i++)
// {
// matrix [i, j] = Rand. NextDouble () ;
// }
// }
// return matrix;
// voidPrintMatrix (double [,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); i++)
// }
// }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите строку: ");
// int row = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец: ");
// int column = Convert.ToInt32(Console.ReadLine()) - 1;
// int n = 2
// int m = 4
// int [,] GetMatrix (int n, int m, int min, int max)
// {
// int[] matrix = new int (m, n) ;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = random.Next(100, 999);
// }
// }
// voidPrintMatrix (int [,] matrix);
// if (row < 0 || row > matrix.GetLength(0) - 1 | column < 0 || column(
// matrix.GetLength(1) - 1)
// {
// Console.WriteLine("Элемент не существует ");
// }
// else
// {
// Console.WriteLine("В указанных координатах {row}, {column} :{Значение элемента массива = {0}");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int sum = 0;
// int [,] GetMatrix (int n, int m, int min, int max)
// {
// int[] matrix = new int (m, n) ;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// // for (int j = 0; j < matrix.GetLength(1); j++)
// // {
// // matrix[i, j] = random.Next(10, 99);
// // }
// // }
// // void GetSr (int [,] matrix)
// // {
// // for (int i = 0; i < matrix.GetLength(0); i++)
// // {
// // for (int j = 0; j < matrix.GetLength(1); j++)
// // sum += matrix [i,j]
// // }
// // Console.WriteLine ($"Сумма элементов в строчке {i} =×{sum}/ matrix. GetLength(1)")
// // }