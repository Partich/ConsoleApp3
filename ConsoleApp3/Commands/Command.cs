namespace ConsoleApp3.Commands
{
    public abstract class Command
    {
        public abstract void Execute(string[]? command);

        public static CommandFactory Factory { get; } = new CommandFactory();

        public string Result { get; protected set; }

        protected bool IsValid(string[]? command, string expected, int expectedCommandLength)
        {
            if (command is null
                || command.Length != expectedCommandLength
                || !command[0].Equals(expected, StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }

            return true;
        }
    }
}
