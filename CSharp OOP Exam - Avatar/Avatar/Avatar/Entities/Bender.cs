namespace Avatar.Entities
{
    using System;

    public abstract class Bender
    {
        private string name;
        private int power;

        public Bender(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public string Name {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public int Power {
            get
            {
                return this.power;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.power = value;
            }
        }

        public abstract double GetPower();

        public override string ToString()
        {
            string benderType = this.GetType().Name;
            int typeEnd = benderType.IndexOf("Bender");
            benderType = benderType.Insert(typeEnd, " ");

            return $"{benderType}: {this.Name}, Power: {this.Power}";
        }
    }
}
