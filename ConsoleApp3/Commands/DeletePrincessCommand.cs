using System.Collections.Generic;

namespace ConsoleApp3.Commands
{
    public class DeletePrincessCommand : Command
    {
        private SortedList<string, Princess> _princesses;

        public DeletePrincessCommand(SortedList<string, Princess> princesses)
        {
            _princesses = princesses;
        }

        public override void Execute(string[]? command)
        {
            if (!IsValid(command, "delete", 2))
            {
                throw new InvalidOperationException("Неправильный ввод команды");
            }

            DeletePrinces(command[1]);
        }

        private void DeletePrinces(string index)
        {
            var princess = _princesses[index];
            _princesses.Remove(index);
            Result = $"Princes \"{princess.Name}\" has been removed.";
        }
    }
}
