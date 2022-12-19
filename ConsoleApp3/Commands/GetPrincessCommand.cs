using System.Collections.Generic;

namespace ConsoleApp3.Commands
{
    public class GetPrincessCommand : Command
    {
        private SortedList<string, Princess> _princesses;

        public GetPrincessCommand(SortedList<string, Princess> princesses)
        {
            _princesses = princesses;
        }

        public override void Execute(string[]? command)
        {
            if (!IsValid(command, "get", 2))
            {
                throw new InvalidOperationException("Неправильный ввод команды");
            }

            Result = _princesses[command[1]].ToString();
        }
    }
}
