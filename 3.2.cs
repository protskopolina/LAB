namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
             
                Console.Write("Введіть розмір матриці n (n x n): ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Введіть значення x: ");
                double x = double.Parse(Console.ReadLine());

                double[,] A = new double[n, n];

               
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        A[i, j] = Math.Sin(i + j + 2) * x;

                // Обробка кожного рядка
                for (int i = 0; i < n; i++)
                {
                    double diagonalEl = A[i, i];

                    // Заміна найбільшого елементу в рядку на діагональний
                    int maxIndex = 0;
                    for (int j = 1; j < n; j++)
                        if (Math.Abs(A[i, j]) > Math.Abs(A[i, maxIndex]))
                            maxIndex = j;

                    A[i, maxIndex] = diagonalEl;

                    // Заміна від'ємних елементів їх кубами
                    for (int j = 0; j < n; j++)
                        if (A[i, j] < 0)
                            A[i, j] = Math.Pow(A[i, j], 3);

                    // Сортування елементів рядка
                   Array.Sort(A, i);
                }

               
                Console.WriteLine("\nМатриця після обробки:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write("{0,8:F2} ", A[i, j]);
                    Console.WriteLine();
                }

                Console.ReadKey();
            }

            
                    }
                }
            }
