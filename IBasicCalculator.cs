using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2FinalLabTask2
{
    interface IBasicCalculator
    {
        int Sum(int x, int y);
        int Sub(int x, int y);
        int Mul(int x, int y);
        int Div(int x, int y);
    }
}
