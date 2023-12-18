using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTwo
{
    internal class Calculator
    {
        public double FirstValue {  get; private set; }
        public double SecondValue { get; private set; }

        public Calculator(double firstValue, double secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
        }
        
        public void Multi()
        {
            Console.WriteLine($"Результат умножения: {FirstValue * SecondValue}"); 
        }
        public void Division()
        {
            Console.WriteLine($"Результат деления: {FirstValue/SecondValue}");
        }
        public void Addition()
        {
            Console.WriteLine($"Результат сложения: {FirstValue + SecondValue}");
        }
        public void Subtrction()
        {
            Console.WriteLine($"Результат вычитания: {FirstValue - SecondValue}");
        }
    }
}
