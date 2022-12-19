using System.Collections.Generic;

namespace ConsoleApp3.Commands
{
    public class AddPrincessCommand : Command
    {
        private SortedList<string, Princess> _princesses;

        public AddPrincessCommand(SortedList<string, Princess> princeses)
        {
            _princesses = princeses;
        }

        public override void Execute(string[]? command)
        {
            if (!IsValid(command, "add", 6))
            {
                throw new InvalidOperationException("Неправильный ввод команды");
            }

            var princes = CreatePrinces(command);

            _princesses.Add(princes.Index, princes);
            Result = $"Princes \"{princes.Name}\" has been added.";
        }

        private Princess CreatePrinces(string[] command)
        {
            return new Princess
            {
                Index = command[1],
                Name = command[2],
                Age = command[3],
                HairColor = command[4],
                EyesColor = command[5]
            };
        }
    }
}
