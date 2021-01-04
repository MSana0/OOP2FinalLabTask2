using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2FinalLabTask2
{
    interface IScientificCalculator
    {
        void Factorial();
        double Fraction();
    }
    class SciCal : IScientificCalculator
    {
        double res;
        public double Fraction(double num1, double num2)
        {
            Console.WriteLine("Dividend: " + num1 + "Divisor: " + num2);
            if (num1%num2==0)
            {
                res = num1 / num2;
                Console.WriteLine("Result: " + res);
                return 0;
            }
            else
            {
                int a = Convert.ToInt32(num1 / num2);
                double b = num1 % num2;
                res = num1 / num2;
                Console.WriteLine("Answer: " + res);
                Console.WriteLine("Wuotient: " + a + " Remainder: " + b);
            }
        }
        public int Factorial(int num)
        {
            Console.WriteLine("Factorial of number: " + num);
            int fac = 1;
            for(int i =1; i<=num;i++)
            {
                Factorial *= i;
            }
            int r = fac;
            Console.WriteLine("Factorial: " + r);
            return 0;
        }
    }
}
