using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Commands
{
    public class ListPrincessCommand : Command
    {
        private SortedList<string, Princess> _princesses;

        public ListPrincessCommand(SortedList<string, Princess> princesses)
        {
            _princesses = princesses;
        }

        public override void Execute(string[]? command)
        {
            if (!IsValid(command, "list", 1))
            {
                throw new InvalidOperationException("Неправильный ввод команды");
            }

            var maxLength = _princesses.Max(x => x.Key.Length);
            var builder = new StringBuilder();

            foreach (var item in _princesses.OrderBy(p => p.Key.PadLeft(maxLength, '0')))
            {
                builder.AppendFormat("{0}.", item.Key);
                builder.AppendFormat("\tName: {0}\n", item.Value.Name);
                builder.AppendFormat("\tAge: {0}\n", item.Value.Age);
                builder.AppendFormat("\tHair: {0}\n", item.Value.HairColor);
                builder.AppendFormat("\tEyes: {0}\n\n", item.Value.EyesColor);
            }

            Result = builder.ToString();
        }
    }
}
