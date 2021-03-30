using MathDemo.Contracts;

using System;
using System.Collections.Generic;
using System.Text;

namespace MathDemo
{
    internal class Add : IOperation
    {

        public Add()
        {
            this.a = a;
            this.b = b;
        }

        public int a { get ; set ; }

        public int b { get ; set ; }

        public int Result { get; private set; }

        public void Run()
        {
            Result = a + b;
        }
    }
}
