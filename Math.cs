using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathNamespace
{
    public class Math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public ulong Factorial(int n)
        {
            int i; 
            ulong factorial = 1;

            for (i = 1; i <= n; i++){
                factorial = factorial * (ulong) i;
            }      
           return factorial;
        }
    }
}