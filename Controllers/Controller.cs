﻿namespace Calculator.Controllers
{
    public class Controller : IController
    {
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
