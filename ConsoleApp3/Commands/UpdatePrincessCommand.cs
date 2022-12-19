using System.Collections.Generic;

namespace ConsoleApp3.Commands
{
    public class UpdatePrincessCommand : Command
    {
        private SortedList<string, Princess> _princesses;

        public UpdatePrincessCommand(SortedList<string, Princess> princesses)
        {
            _princesses = princesses;
        }

        public override void Execute(string[]? command)
        {
            if (!IsValid(command, "update", 6))
            {
                throw new InvalidOperationException("Неправильный ввод команды");
            }

            UpdatePrinces(command);
            var princess = _princesses[command[1]];
            Result = $"Princes \"{princess.Name}\" has been updated.";
        }

        private void UpdatePrinces(string[] command)
        {
            var princes = _princesses[command[1]];
            princes.Index = command[1];
            princes.Name = command[2];
            princes.Age = command[3];
            princes.HairColor = command[4];
            princes.EyesColor = command[5];    
        }
    }
}
