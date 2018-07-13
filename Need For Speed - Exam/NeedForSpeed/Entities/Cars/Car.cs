namespace NeedForSpeed.Entities.Cars
{
    using System;
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
            this.Brand = brand;
            this.Model = model;
            this.YearOfProduction = yearOfProduction;
            this.HorsePower = horsepower;
            this.Acceleration = acceleration;
            this.Suspension = suspension;
            this.Durability = durability;
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.brand = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.model = value;
            }
        }

        public int YearOfProduction
        {
            get
            {
                return this.yearOfProduction;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.yearOfProduction = value;
            }
        }

        public int HorsePower
        {
            get
            {
                return this.horsepower;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.horsepower = value;
            }
        }

        public int Acceleration
        {
            get
            {
                return this.acceleration;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.acceleration = value;
            }
        }

        public int Suspension
        {
            get
            {
                return this.suspension;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.suspension = value;
            }
        }

        public int Durability
        {
            get
            {
                return this.durability;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.durability = value;
            }
        }

        public virtual void Tune(int tuneIndex, string addOn)
        {
            this.horsepower += tuneIndex;
            this.suspension += tuneIndex * 50 / 100;
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
