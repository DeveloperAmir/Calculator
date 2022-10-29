using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculaor
{
    interface ICalculator
    {
        double plus(double num1, double num2);
        double minus(double num1, double num2);
        double divide(double num1, double num2);
        double multiples(double num1, double num2);
        double Power(double number1, double number2);

    }
}
