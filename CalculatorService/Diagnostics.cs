using System;

namespace CalculatorService
{
    public class Diagnostics : IDiagnostics
    {
        public void LogtoConsole(string input)
        {
            Console.WriteLine(input);
        }
    }
}
