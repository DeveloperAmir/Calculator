using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculaor
{
    class Calculator : ICalculator
    {
        public double divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double minus(double num1, double num2)
        {
            return num1 - num2;
            ;
        }

        public double multiples(double num1, double num2)
        {
            return num1 * num2;
            ;
        }

        public double plus(double num1, double num2)
        {
            return num1 + num2;
            
        }

        public double Power(double number1, double number2)
        {
          double power = Math.Pow(number1, number2);
            return power;
        }
    }
}
