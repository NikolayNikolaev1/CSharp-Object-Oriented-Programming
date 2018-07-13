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
            string command = cmdArgs[0];

            switch (command)
            {
                case "register":
                    this.RegisterCommand(cmdArgs);
                    break;
                case "check":
                    Console.WriteLine(this.CheckCommand(cmdArgs));
                    break;
                case "open":
                    this.OpenCommand(cmdArgs);
                    break;
                case "participate":
                    this.ParticipateCommand(cmdArgs);
                    break;
                case "start":
                    Console.WriteLine(this.StartCommand(cmdArgs));
                    break;
                case "park":
                    this.ParkCommand(cmdArgs);
                    break;
                case "unpark":
                    this.UnparkCommand(cmdArgs);
                    break;
                case "tune":
                    break;
            }   
        }

        private void RegisterCommand(string[] cmdArgs)
        {
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
        }

        private string CheckCommand(string[] cmdArgs)
        {
            int id = int.Parse(cmdArgs[1]);
            return manager.Check(id);
        }

        private void OpenCommand(string[] cmdArgs)
        {
            int id = int.Parse(cmdArgs[1]);
            string type = cmdArgs[2];
            int lenght = int.Parse(cmdArgs[3]);
            string route = cmdArgs[4];
            int prizePool = int.Parse(cmdArgs[5]);
            manager.Open(id, type, lenght, route, prizePool);
        }

        private void ParticipateCommand(string[] cmdArgs)
        {
            int carId = int.Parse(cmdArgs[1]);
            int raceId = int.Parse(cmdArgs[2]);
            manager.Participate(carId, raceId);
        }

        private string StartCommand(string[] cmdArgs)
        {
            int raceId = int.Parse(cmdArgs[1]);
            return manager.Start(raceId);
        }

        private void ParkCommand(string[] cmdArgs)
        {
            int id = int.Parse(cmdArgs[1]);
            manager.Park(id);
        }

        private void UnparkCommand(string[] cmdArgs)
        {
            int id = int.Parse(cmdArgs[1]);
            manager.Unpark(id);
        }
    }
}
