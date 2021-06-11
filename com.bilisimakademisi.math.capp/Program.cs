using System;

namespace com.bilisimakademisi.math.capp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator casio = new Calculator();

            //string text = casio.StartCalculator("SONER");

            //Console.WriteLine(text);

            decimal result = casio.Sum(1, 2, 3, 4, 5, 6, 7);

            Console.WriteLine(result);

           // Console.WriteLine(casio.Sum(1, 2, 3, 4, 5, 6, 7));


            // casio.Multiply(10,20);

            //casio.CalculateArea(5);
            //casio.CalculateArea(5,4);

            /* Dışardan Değer Almayan ve Geriye Değer Dönemeyen*/
            //Calculator.StartCalculator();

            /* Dışarıdan Değer Alan ve Geriye Değer Dönmeyen*/
            //string name = "Digitech";
            //Calculator.StartOtherCalculator(name);

            /* Dışarıdan Değer Almayan ve Geriye Değer Dönen*/
            //decimal result = Calculator.PI();
            //Console.WriteLine(result);

            /* Dışarıdan Değer Almayan ve Geriye Değer Dönen*/
            //decimal first = 10.5M;
            //decimal second = 2m;
            //decimal multipleResult = Calculator.Multiply(first, second);
            //decimal multipleResult2 = Calculator.Multiply(2, 5);
            //Console.WriteLine(multipleResult2);

            //string calcName = Calculator.GetCalculatorName();
            //Console.WriteLine(calcName);

        }
    }
}
