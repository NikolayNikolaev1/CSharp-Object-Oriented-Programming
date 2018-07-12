namespace NeedForSpeed.Entities.Cars
{
    public class ShowCar : Car
    {
        public ShowCar(string brand, string model, int yearOfProduction, int horsepower,
            int acceleration, int suspension, int durability) 
            : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
        {
        }
    }
}
