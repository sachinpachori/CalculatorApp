using System;

namespace CalculatorService
{
    public class SimpleCalculator : ISimpleCalculator
    {
        private IDiagnostics _diagnostics;

        public SimpleCalculator()
        {
        }

        public SimpleCalculator(IDiagnostics Diagnostics)
        {
            _diagnostics = Diagnostics;
        }

        public int Add(int start, int amount)
        {
            var result = start + amount;
            if(_diagnostics!=null)
                _diagnostics.LogtoConsole(result.ToString());

            return result;
        }

        public int Subtract(int start, int amount)
        {
            var result = start - amount;
            if (_diagnostics != null)
                _diagnostics.LogtoConsole(result.ToString());

            return result;
        }

        public int Multiply(int start, int by)
        {
            var result = start * by;
            if (_diagnostics != null)
                _diagnostics.LogtoConsole(result.ToString());

            return result;
        }

        public int Divide(int start, int by)
        {
            try
            {
                var result = start / by;
                if (_diagnostics != null)
                    _diagnostics.LogtoConsole(result.ToString());

                return result;
            }
            catch (DivideByZeroException ex)
            {
                return -999;
            }
        }
    }
}

