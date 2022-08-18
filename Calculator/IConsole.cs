namespace Calculator
{
    public interface IConsole
    {
        void WriteLine(string input);
        void WriteLine(string input, params object[] args);
        string ReadLine();
        void Write(string input);
    }
    class DefaultConsole : IConsole
    {
        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }
        public void WriteLine(string input, params object[] args)
        {
            Console.WriteLine(input, args);
        }
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string input)
        {
            Console.Write(input);
        }
    }
}
