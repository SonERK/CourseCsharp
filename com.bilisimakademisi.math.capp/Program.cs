using com.bilisimakademisi.course.models;
using System;

namespace com.bilisimakademisi.math.capp
{
    class Program
    {
        static void Main(string[] args)
        {

            int val = 0;

            if (val==0)
            {
                Console.WriteLine("Value is zero");
            }
            else
            {

            }

            #region AccessModifiers

            Vehicle fiat = new Vehicle();

            // bool acumulatorResult = fiat.CheckEnergy();
            bool result = fiat.StartEngine();

            // Console.WriteLine(result);

            Vehicle bmw = new Vehicle();

            int wheels = bmw.GetWheelCount();
            decimal luggageSize = bmw.LuggageSize();

            // Console.WriteLine(wheels);
            if (wheels < 2)
            {
                Console.WriteLine("This is not a vehicle");
            }
            else if (wheels == 2)
            {
                if (luggageSize < 40)
                {
                    Console.WriteLine("This is a motocycle");
                }
                else
                {
                    Console.WriteLine("This is amazing motocyle");
                }
            }
            else if (wheels == 4 && luggageSize < 1000)
            {
                Console.WriteLine("This is a car");
            }
            else if (wheels > 4 || luggageSize > 1000)
            {
                Console.WriteLine("This is a Truck");
            }
            else
            {
                Console.WriteLine("Values are out of range");
            }

            #endregion

            #region Methods

            // Calculator casio = new Calculator();

            //string text = casio.StartCalculator("SONER");

            //Console.WriteLine(text);

            //decimal result = casio.Sum(1, 2, 3, 4, 5, 6, 7);

            //Console.WriteLine(result);

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
            #endregion
        }
    }
}
