﻿namespace Calculator.Controllers
{
    public interface IController
    {
        double Add(double firstNumber, double secondNumber);

        double Subtract(double firstNumber, double secondNumber);

        double Multiply(double firstNumber, double secondNumber);

        double Divide(double firstNumber, double secondNumber);
    }
}
