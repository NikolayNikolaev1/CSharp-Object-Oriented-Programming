namespace NeedForSpeed.Entities.Cars
{
    public abstract class Car
    {
        private string brand;
        private string model;
        private int yearOfProduction;
        private int horsepower;
        private int acceleration;
        private int suspension;
        private int durability;

        public Car(string brand, string model, int yearOfProduction, int horsepower, 
            int acceleration, int suspension, int durability)
        {
            this.brand = brand;
            this.model = model;
            this.yearOfProduction = yearOfProduction;
            this.horsepower = horsepower;
            this.acceleration = acceleration;
            this.suspension = suspension;
            this.durability = durability;
        }
    }
}
