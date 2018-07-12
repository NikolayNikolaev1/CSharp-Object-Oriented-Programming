namespace NeedForSpeed.Entities.Cars
{
    using System.Text;

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{brand} {model} {yearOfProduction}");
            sb.AppendLine($"{horsepower} HP, 100 m/h in {acceleration} s");
            sb.AppendLine($"{suspension} Suspension force, {durability} Durability");

            return sb.ToString();
        }
    }
}
