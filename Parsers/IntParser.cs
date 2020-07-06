using System;

namespace Calculator.Parsers
{
    public class IntParser : IParser<int, string>
    {
        public int Parse(string input)
            => Int32.Parse(input);
    }
}
