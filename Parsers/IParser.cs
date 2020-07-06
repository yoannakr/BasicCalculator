namespace Calculator.Parsers
{
    public interface IParser<to, from>
    {
        to Parse(from input);
    }
}
