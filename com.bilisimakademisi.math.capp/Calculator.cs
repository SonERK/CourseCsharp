using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.bilisimakademisi.math.capp
{
    class Calculator
    {
        public void StartCalculator()
        {
           // Console.WriteLine("Casio Calculator Started...");
        }

        /*OverloadMethod*/
        public string StartCalculator(string calculatorName)
        {
            string message = calculatorName + " is opening...";

            return message;
        }

        public void StartOtherCalculator(string calculatorName)
        {
            string text = calculatorName + " Calculator Started...";

           // Console.WriteLine(text);
        }

        public decimal PI()
        {
            return 3.14159m;
        }

        public decimal Multiply(decimal number1, decimal number2)
        {
            decimal result = number1 * number2;

            return result;
        } 
        
        public string GetCalculatorName()
        {
            string calculatorName = "CASIO FX";

            return calculatorName;
        }

        public decimal CalculateArea(decimal r, decimal pi = 3.14159m)
        {
            decimal result = pi * r * r;

            return result;
        }

        public decimal Sum(params int[] numbers)
        {
            // decimal summary = numbers.Sum();

            // return summary;

            return numbers.Sum();
        }
    }
}
