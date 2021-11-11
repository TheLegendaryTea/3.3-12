using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("введите x");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("введите n");
                int n = int.Parse(Console.ReadLine());
                double S = 0;
                for (int i = 1; i <=n; i++)
                {
                    S += Math.Pow(x, i) * Math.Cos(i * Math.PI / 3) / i;
                }
                Console.WriteLine("S={0:F2}",S);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
