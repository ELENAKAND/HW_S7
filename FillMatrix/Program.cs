/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double[,] InitMatrix(int k, int l)
            {
                double[,] matrix1 = new double[k, l];
                Random randomizer = new Random();
 
                for (int i = 0; i < k; i++)// заполнение строк
                {
                    for (int j = 0; j < l; j++)// заполнение столбцов 
                    {
                        matrix1[i, j] = randomizer.NextDouble()*(10 + 9.99) - 9.99;
                    }
                }
                return matrix1;
            }
 
            void PrintMatrix(double[,] matrix2)
            {
                for (int i = 0; i < matrix2.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        Console.Write($"{matrix2[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
 
            Console.WriteLine("Введите число m:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число n:");
            int n = int.Parse(Console.ReadLine());
 
            double[,] matrix = InitMatrix(m, n);
 
            Console.WriteLine($"Матрица размером {m}x{n}:");
            Console.WriteLine();
 
            PrintMatrix(matrix);