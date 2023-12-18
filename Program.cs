using System.Diagnostics;

namespace HomeworkTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            double firstValue;
            double secondValue;
            while (isWork)
            {
                Console.WriteLine("Введите первое число: ");
                if (double.TryParse(Console.ReadLine(), out double value))
            {
                    firstValue = value;                    
                }
            else
                {
                    Console.WriteLine("До свидания!");
                    return;
                }
                Console.WriteLine("Введите второе число: ");
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    secondValue = value;
                }
                else
                {
                    Console.WriteLine("До свидания!");
                    return;
                }

                var calc = new Calculator(firstValue, secondValue);
                Console.WriteLine("Какую операцию хотите выполнить:" +
                    "\nУмножить: *; " +
                    "\nПоделить: /; " +
                    "\nСложить: +; " +
                    "\nВычесть: -; ");
                bool isCorrectOperator = false;
                while (isCorrectOperator == false)
                {
                    switch (Console.ReadLine())
                    {
                        case "+":
                            calc.Addition();
                            isCorrectOperator = true;
                            break;
                        case "-":
                            calc.Subtrction();
                            isCorrectOperator = true;
                            break;
                        case "*":
                            calc.Multi();
                            isCorrectOperator = true;
                            break;
                        case "/":
                            calc.Division();
                            isCorrectOperator = true;
                            break;
                        case "e":
                            Console.WriteLine("До свидания!");
                            isCorrectOperator = true;
                            isWork = false;
                            break;

                        default:
                            Console.WriteLine("Введедена неверная операция, попробуйте еще раз....");
                            break;
                    }
                }
               
            }
        }
    }
}
