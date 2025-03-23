namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть х:");
            double x = double.Parse(Console.ReadLine() ?? "0");
            double S = 1, term;
            int n = 1;
            do
            {
                term = Math.Cos(n * x) / Factorial(n);
                S += term;
                n++;
            } while (Math.Abs(term) >= 0.1);
            double y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
            Console.WriteLine($"РЕЗУЛЬТАТ:\nS(x) = {S:F6}, y(x) = {y:F6},|S - y| = {Math.Abs(S - y):F6}");
        }
        static double Factorial(int n )
        {
            double fact = 1;
            for (int i = 2; i <= n; i++) fact *= i;
            return fact;

        }
    }
}
