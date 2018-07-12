namespace NeedForSpeed.Entities.Cars
{
    using System.Collections.Generic;

    public class PerformanceCar : Car
    {
        private List<string> addOn;

        public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower,
            int acceleration, int suspension, int durability) 
            : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
        {
            this.addOn = new List<string>();
        }
    }
}
