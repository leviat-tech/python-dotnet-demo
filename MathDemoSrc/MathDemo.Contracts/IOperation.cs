using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDemo.Contracts
{
    public interface IOperation
    {
        int a { get; set; }

        int b { get; set; }

        int Result { get; }

        void Run();
    }
}
