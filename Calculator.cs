using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2FinalLabTask2
{
    abstract class Calculator
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public Calculator() { }
        public Calculator(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public int Sum(int x, int y)
        {
            Console.WriteLine("Enter two numbers for sum");
            Console.ReadKey();
            Console.ReadKey();
            int sum = x + y;
            return sum;
        }
        public int Sub(int x, int y)
        {
            Console.WriteLine("Enter two numbers for the subtraction");
            Console.ReadKey();
            Console.ReadKey();
            int sub = x - y;
            return sub;
        }
        public int Mul(int x, int y)
        {
            Console.WriteLine("Enter two numbers to multiply");
            Console.ReadKey();
            Console.ReadKey();
            int mul = x * y;
            return mul;
        }
        public float Div(int x, int y)
        {
            Console.WriteLine("Enter two numbers to divide");
            Console.ReadKey();
            Console.ReadKey();
            int div = x / y;
            return div;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Model: " + Model);
        }
    }
}
