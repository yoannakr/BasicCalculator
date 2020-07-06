using Calculator.Engines;
using Calculator.IO;
using System;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
