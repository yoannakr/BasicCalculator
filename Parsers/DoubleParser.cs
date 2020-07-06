namespace Calculator.Parsers
{
    public class DoubleParser : IParser<double, string>
    {
        public double Parse(string input)
        {
            return double.Parse(input);
        }
    }
}
