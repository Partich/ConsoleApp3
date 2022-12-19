using ConsoleApp3.Commands;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        private static SortedList<string, Princess> ParseFile(string path)
        {
            var disneyPrincesses = File.ReadAllLines(path);
            var list = new SortedList<string, Princess>();

            for (var i = 0; i < disneyPrincesses.Length; i++)
            {
                var input = disneyPrincesses[i].Split(" | ");

                if(input.Length != 5)
                {
                    throw new ArgumentException("В файле неверная информация");
                }

                list.Add(input[0], new Princess
                {
                    Index = input[0],
                    Name = input[1],
                    Age = input[2],
                    HairColor = input[3],
                    EyesColor = input[4]
                });
            }

            return list;
        }

        static void Main(string[] args)
        {
            var path = "disney-princesses.txt";
            var princessesList = ParseFile(path);

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите Команду: ");
                    var input = Console.ReadLine();
                    var command = Command.Factory.Create(input, princessesList);
                    var splitted = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    command.Execute(splitted);
                    Console.WriteLine(command.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
