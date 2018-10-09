using CalculatorService;
using System;
using static System.String;

namespace CalculatorApp
{
    class Program
    {
        static readonly SimpleInjector.Container container;
        static Program()
        {
            container = new SimpleInjector.Container();
            container.Register<IDiagnostics, Diagnostics>();
            container.Verify();           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
           
            IDiagnostics _diag = container.GetInstance<IDiagnostics>();
            SimpleCalculator simp = new SimpleCalculator(_diag);
            Calculate(simp);
        }

        private static void Calculate(SimpleCalculator simp)
        {           
            Console.WriteLine("Enter 1st number:");
            string first = Console.ReadLine();
            if (IsNullOrWhiteSpace(first))
                Console.WriteLine("Invalid input");
            else
            {
                int.TryParse(first, out int fNum);
                Console.WriteLine("Enter 2nd number:");
                string second = Console.ReadLine();
                if (IsNullOrWhiteSpace(second))
                    Console.WriteLine("Invalid input");
                else
                {
                    int.TryParse(second, out int sNum);
                    Console.WriteLine("Enter the operation(A for Add, S for Subtract, M for Multiply, D for Divide):");
                    string operation = Console.ReadLine();

                    switch (operation)
                    {
                        case "A":
                            simp.Add(fNum, sNum).ToString();
                            break;
                        case "S":
                            simp.Subtract(fNum, sNum).ToString();
                            break;
                        case "M":
                            simp.Multiply(fNum, sNum).ToString();
                            break;
                        case "D":
                            simp.Divide(fNum, sNum).ToString();
                            break;
                        default:
                            Console.WriteLine("Invalid operation choice");
                            break;
                    }
                    
                }
            }
            Console.WriteLine("Press enter to start again....");
            Console.ReadLine();
            Calculate(simp);
        }
    }
}
