using System;
using Calculator.Enums;

namespace Calculator.Parsers
{
    public class OptionsParser : IParser<Options, int>
    {
        public Options Parse(int input)
        {
            return (Options)input;
        }
    }
}
