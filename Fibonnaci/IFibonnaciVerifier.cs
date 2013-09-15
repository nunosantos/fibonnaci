using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonnaci
{
    public interface IFibonnaciVerifier
    {
        bool VerifySequenceFibonnaciReader(IFibonnaciReader fibonnaci);
    }
}
