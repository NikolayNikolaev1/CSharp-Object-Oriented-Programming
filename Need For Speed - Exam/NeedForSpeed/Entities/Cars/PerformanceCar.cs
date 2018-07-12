namespace NeedForSpeed.Entities.Cars
{
    public class PerformanceCar : Car
    {
        public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower,
            int acceleration, int suspension, int durability) 
            : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
        {
        }
    }
}
