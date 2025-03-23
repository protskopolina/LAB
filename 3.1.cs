namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10], B = new int[10], C = new int[10];
            int coutB = 0, coutC = 0;
            double sumA = 0, sumB = 0, sumC = 0;

            Console.WriteLine("Введіть 10 чисел:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = Convert.ToInt32(Console.ReadLine());
                sumA += A[i];
                if (A[i] > 0)
                {
                    B[coutB++] = A[i];
                    sumB += A[i];
                }
                else if (A[i] < 0)
                {
                    C[coutC++] = A[i];
                    sumC += A[i];
                }
            }

            // Display positive numbers (B)
            Console.WriteLine("Масив В (додатні): ");
            if (coutB > 0)
                for (int i = 0; i < coutB; i++)
                    Console.Write(B[i] + " ");
            else
                Console.WriteLine("Немає");

            // Display negative numbers (C)
            Console.WriteLine("\nМасив C (від'ємні): ");
            if (coutC > 0)
                for (int i = 0; i < coutC; i++)
                    Console.Write(C[i] + " ");
            else
                Console.WriteLine("Немає");

            // Calculate and display averages
            Console.WriteLine();
            Console.WriteLine($"Середнє арифметичне A: {sumA / 10:F2}");

           
            Console.WriteLine($"Середнє арифметичне B: {(coutB > 0 ? sumB / coutB : 0):F2}");

       
            Console.WriteLine($"Середнє арифметичне C: {(coutC > 0 ? sumC / coutC : 0):F2}");
        }
    }
}
