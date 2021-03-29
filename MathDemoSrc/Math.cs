using System;

namespace MathDemo
{
    public class Math
    {
        public int Add(int a, int b)
        {
            var add = new Add(a, b);
            return add.Run();
        }

        public int Subtract(int a, int b)
        {
            var subtract = new Subtract(a, b);
            return subtract.Run();
        }

        public ulong Factorial(int n)
        {
            int i;
            ulong factorial = 1;

            for (i = 1; i <= n; i++)
            {
                factorial = factorial * (ulong)i;
            }
            return factorial;
        }
    }
}
