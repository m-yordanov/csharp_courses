using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] argumetns = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string commandName = argumetns[0];

            string[] commandArguments = argumetns.Skip(1).ToArray();

            Type commandType = Assembly.GetEntryAssembly().GetTypes().FirstOrDefault(t => t.Name == $"{commandName}Command");

            if (commandType is null)
            {
                throw new InvalidOperationException("Command not found");
            }

            ICommand commandInstance = Activator.CreateInstance(commandType) as ICommand;

            string result = commandInstance.Execute(commandArguments);

            return result.ToString();
        }
    }
}
