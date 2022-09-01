// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int a = InputNumbers("Введите a: ");
// int b = InputNumbers("Введите b: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[a, b];
// CreateArray(array);
// WriteArray(array);

// Console.WriteLine($"\nОтсортированный массив: ");
// OrderArrayLines(array);
// WriteArray(array);

// void OrderArrayLines(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1)-1; k++)
//       {
//        	if (array[i,k] < array[i,k + 1])
// 					{
// 						int temp = array[i,k + 1];
// 						array[i,k + 1] = array[i,k];
// 						array[i,k] = temp;
// 					}
//       }
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = int.Parse(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }







// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int a = InputNumbers("Введите a: ");
// int b = InputNumbers("Введите b: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[a, b];
// CreateArray(array);
// WriteArray(array);

// int minSum = 0;
// int sumLine = SumElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSum = i;
//   }
// }

// Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


// int SumElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = int.Parse(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }







// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int a = InputNumbers("Введите число строк первой матрицы: ");
// int b = InputNumbers("Введите число столбцов первой матрицы (и строк 2-й): ");
// int c = InputNumbers("Введите число столбцов второй матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] firstMartrix = new int[a, b];
// CreateArray(firstMartrix);
// Console.WriteLine($"\nПервая матрица:");
// WriteArray(firstMartrix);

// int[,] secondMartrix = new int[b, c];
// CreateArray(secondMartrix);
// Console.WriteLine($"\nВторая матрица:");
// WriteArray(secondMartrix);

// int[,] resultMatrix = new int[a,c];

// MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
// Console.WriteLine($"\nПроизведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secondMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = int.Parse(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }