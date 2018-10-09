using CalculatorService;
using System;
using static System.String;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");            
            SimpleCalculator simp = new SimpleCalculator();
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
                            Console.WriteLine(simp.Add(fNum, sNum).ToString());
                            break;
                        case "S":
                            Console.WriteLine(simp.Subtract(fNum, sNum).ToString());
                            break;
                        case "M":
                            Console.WriteLine(simp.Multiply(fNum, sNum).ToString());
                            break;
                        case "D":
                            Console.WriteLine(simp.Divide(fNum, sNum).ToString());
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
