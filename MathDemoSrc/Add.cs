using System;
using System.Collections.Generic;
using System.Text;

namespace MathDemo
{
    public class Add
    {
        private int a;
        private int b;

        public Add(int a, int b)
        {
            this.a = a;
            this.b = b;

        }

        public int Run()
        {
            return a + b;
        }
    }
}
