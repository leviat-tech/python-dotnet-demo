using MathDemo.Core;

using System;

namespace MathDemo
{
    public class Math
    {
        public int Add(int a, int b)
        {
            var add = Factory.CreateAdd();
            add.a = a;
            add.b = b;
            add.Run();
            return add.Result;
        }

        public int Subtract(int a, int b)
        {
            var subtract = Factory.CreateSubtract();
            subtract.a = a;
            subtract.b = b;
            subtract.Run();
            return subtract.Result;
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
