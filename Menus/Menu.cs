using System;
using Calculator.Enums;
using Calculator.IO;
using Calculator.Parsers;

namespace Calculator.Menus
{
    public class Menu
    {
        private readonly IWriter writer;

        public Menu(IWriter writer)
        {
            this.writer = writer;
        }

        public void DisplayOptions()
        {
            this.writer.WriteLine("----------Calculator Menu----------" +
                                "\nSelect an option from the following:" +
                                "\n#1 - Add" +
                                "\n#2 - Subtract" +
                                "\n#3 - Multiply" +
                                "\n#4 - Divide" +
                                "\n#5 - Exit");
        }

        public int SelectOption(string input)
        {
            IntParser intParser;
            int menuOption;

            try
            {
                intParser = new IntParser();
                menuOption = intParser.Parse(input);

                if (!Enum.IsDefined(typeof(Options), menuOption))
                    throw new InvalidOperationException();
            }
            catch (Exception)
            {
                menuOption = 0;
                this.writer.WriteLine("Invalid option! Try again!");
            }

            return menuOption;
        }
    }
}
