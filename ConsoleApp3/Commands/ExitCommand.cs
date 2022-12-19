using System.Collections.Generic;

namespace ConsoleApp3.Commands
{
    public class ExitCommand : Command
    {
        public ExitCommand(SortedList<string, Princess> princeses)
        {
            _ = princeses;
        }

        public override void Execute(string[]? command)
        {
            if (!IsValid(command, "exit", 1))
            {
                throw new InvalidOperationException("Неправильный ввод команды");
            }

            Environment.Exit(0);
        }
    }
}
