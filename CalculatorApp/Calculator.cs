using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        public double Add(double firstInput, double secondInput)
        {
            return firstInput + secondInput;
        }
        public double Sub(double firstInput, double secondInput)
        {
            return firstInput - secondInput;
        }
        public double Mul(double firstInput, double secondInput)
        {
            return firstInput * secondInput;
        }
        public double Div(double firstInput, double secondInput)
        {
            return firstInput / secondInput;
        }
    }
}
