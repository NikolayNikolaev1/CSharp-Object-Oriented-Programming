namespace NeedForSpeed.Core
{
    using Entities;
    using Entities.Cars;
    using Entities.Races;
    using System.Collections.Generic;

    public class CarManager
    {
        private Garage garage;
        private Dictionary<int, Car> cars;
        private Dictionary<int, Race> races;

        public CarManager()
        {
            this.cars = new Dictionary<int, Car>();
            this.races = new Dictionary<int, Race>();
            this.garage = new Garage();
        }

        public void Register(int id, string type, string brand, string model, int yearOfProduction,
            int horsepower, int acceleration, int suspension, int durability)
        {
            if (type == "Performance")
            {
                this.cars.Add(id, new PerformanceCar(brand, model, yearOfProduction,
                    horsepower, acceleration, suspension, durability));
            }
            else if (type == "Show")
            {
                this.cars.Add(id, new ShowCar(brand, model, yearOfProduction,
                    horsepower, acceleration, suspension, durability));
            }
        }

        public string Check(int id) => this.cars[id].ToString();

        public void Open(int id, string type, int length, string route, int prizePool)
        {
            switch (type)
            {
                case "Casual":
                    this.races.Add(id, new CasualRace(length, route, prizePool));
                    break;
                case "Drag":
                    this.races.Add(id, new DragRace(length, route, prizePool));
                    break;
                case "Drift":
                    this.races.Add(id, new DragRace(length, route, prizePool));
                    break;
            }
        }

        public void Participate(int carId, int raceId)
        {
            this.races[raceId].Participants.Add(cars[carId]);
        }

        public string Start(int id)
        {
            return ToString();
        }

        public void Park(int id)
        {

        }

        public void Unpark(int id)
        {

        }

        public void Tune(int tuneIndex, string addOn)
        {

        }
    }
}
