namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y;
            double a = 1.0;
            double xstart = -4, xend = 4, dx = 0.25;

            for (double x = xstart; x <= xend; x += dx)
            {
                y = (a * a * Math.Exp(-x)) / (2 + a * a);
                Console.WriteLine($"x = {x:F2}, y = {y:F4}");
            }
        }

    }
}
