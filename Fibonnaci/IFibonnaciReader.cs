using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonnaci
{
    public interface IFibonnaciReader
    {
        void Evaluate(int number, double[] arrayOfNumbers);
    }
}
