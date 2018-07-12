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

        public string Check(int id)
        {
            return ToString();
        }

        public void Open(int id, string type, int length, string route, int prizePool)
        {

        }

        public void Participate(int carId, int raceId)
        {

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
