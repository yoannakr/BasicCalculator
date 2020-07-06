using System;
using Calculator.Controllers;
using Calculator.Enums;
using Calculator.IO;
using Calculator.Menus;
using Calculator.Parsers;

namespace Calculator.Engines
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IController controller = new Controller();
        private readonly OptionsParser optionsParser = new OptionsParser();
        private readonly DoubleParser doubleParser = new DoubleParser();

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            Menu menu = new Menu(writer);
            menu.DisplayOptions();

            double result = 0;

            while (true)
            {
                this.writer.WriteLine("Select your option:");

                string input = this.reader.ReadLine();
                int menuOption = menu.SelectOption(input);

                if (menuOption == 0)
                    continue;

                Options parsedOption = optionsParser.Parse(menuOption);

                if (parsedOption == Options.Exit)
                    Environment.Exit(0);

                double firstNumber = double.MinValue;
                double secondNumber = double.MinValue;

                while (firstNumber == double.MinValue)
                {
                    try
                    {
                        this.writer.WriteLine("FirstNumber:");
                        firstNumber = doubleParser.Parse(this.reader.ReadLine());
                    }
                    catch (FormatException)
                    {
                        this.writer.WriteLine("Please enter numbers!");
                    }
                    catch (Exception)
                    {
                        this.writer.WriteLine("Something went wrong!");
                    }
                }

                while (secondNumber == double.MinValue)
                {
                    try
                    {
                        this.writer.WriteLine("SecondNumber:");
                        secondNumber = doubleParser.Parse(this.reader.ReadLine());
                    }
                    catch (FormatException)
                    {
                        this.writer.WriteLine("Please enter numbers!");
                    }
                    catch (Exception)
                    {
                        this.writer.WriteLine("Something went wrong!");
                    }
                }

                if (parsedOption == Options.Add)
                {
                    result = this.controller.Add(firstNumber, secondNumber);
                }
                else if (parsedOption == Options.Multiply)
                {
                    result = this.controller.Multiply(firstNumber, secondNumber);
                }
                else if (parsedOption == Options.Subtract)
                {
                    result = this.controller.Subtract(firstNumber, secondNumber);
                }
                else if (parsedOption == Options.Divide)
                {
                    result = this.controller.Divide(firstNumber, secondNumber);
                }

                this.writer.WriteLine("Result: " + result);
            }
        }
    }
}
