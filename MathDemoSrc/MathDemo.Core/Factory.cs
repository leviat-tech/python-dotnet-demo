using MathDemo.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDemo.Core
{
    public static class Factory
    {
        public static IOperation CreateAdd()
        {
            return new Add();
        }

        public static IOperation CreateSubtract()
        {
            return new Subtract();
        }
    }
}
