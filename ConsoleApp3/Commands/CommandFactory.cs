namespace ConsoleApp3.Commands
{
    public class CommandFactory
    {
        public Command Create(string input, SortedList<string, Princess> princesses)
        {
            var end = input.IndexOf(' ');

            string command;
            if (end != -1)
            {
                command = input[..end];
            }
            else
            {
                command = input;
            }

            return command switch
            {
                "add" => new AddPrincessCommand(princesses),
                "get" => new GetPrincessCommand(princesses),
                "update" => new UpdatePrincessCommand(princesses),
                "delete" => new DeletePrincessCommand(princesses),
                "list" => new ListPrincessCommand(princesses),
                "exit" => new ExitCommand(princesses),
                _ => throw new ArgumentException("Неправильная командда")
            };
        }
    }
}