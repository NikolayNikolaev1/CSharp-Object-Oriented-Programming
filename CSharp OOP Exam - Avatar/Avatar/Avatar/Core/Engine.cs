namespace Avatar.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private bool isRunning;
        private NationsBuilder nationsBuilder;

        public Engine()
        {
            this.isRunning = true;
            this.nationsBuilder = new NationsBuilder();
        }

        public void Run()
        {
            while (this.isRunning)
            {
                string inputCommand = this.ReadInput();
                List<string> commandParameters = this.ParseInput(inputCommand);
                this.DistributeCommand(commandParameters);
            }
        }

        private void DistributeCommand(List<string> commandParameters)
        {
            string command = commandParameters[0];
            commandParameters.Remove(command);

            switch (command)
            {
                case "Bender":
                    this.nationsBuilder.AssignBender(commandParameters);
                    break;
                case "Monument":
                    this.nationsBuilder.AssignMonument(commandParameters);
                    break;
                case "Status":
                    string status = this.nationsBuilder.GetStatus(commandParameters[0]);
                    this.OutputWriter(status);
                    break;
                default:
                    break;
            }
        }

        private string ReadInput() => Console.ReadLine();

        private List<string> ParseInput(string inputCommand) => inputCommand.Split().ToList();

        private void OutputWriter(string status) => Console.WriteLine(status);
    }
}
