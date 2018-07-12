namespace NeedForSpeed.Core
{
    using System;

    public class Engine
    {
        private CarManager manager;

        public Engine()
        {
            this.manager = new CarManager();
        }

        public void Run()
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Cops Are Here")
            {
                string[] cmdArgs = command.Split();
                ExecuteCommand(cmdArgs);
            }
        }

        public void ExecuteCommand(string[] cmdArgs)
        {
            switch (cmdArgs[0])
            {
                case "register":
                    int id = int.Parse(cmdArgs[1]);
                    string type = cmdArgs[2];
                    string brand = cmdArgs[3];
                    string model = cmdArgs[4];
                    int yearOfProduction = int.Parse(cmdArgs[5]);
                    int horsepower = int.Parse(cmdArgs[6]);
                    int acceleration = int.Parse(cmdArgs[7]);
                    int suspension = int.Parse(cmdArgs[8]);
                    int durability = int.Parse(cmdArgs[9]);
                    manager.Register(id, type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                    break;
                case "check":
                    Console.WriteLine(manager.Check(int.Parse(cmdArgs[1])));
                    break;
                case "open":
                    break;
                case "participate":
                    break;
                case "start":
                    break;
                case "park":
                    break;
                case "unpark":
                    break;
                case "tune":
                    break;
            }
        }
    }
}
