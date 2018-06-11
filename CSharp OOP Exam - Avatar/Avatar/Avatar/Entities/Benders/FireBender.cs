namespace Avatar.Entities.Benders
{
    public class FireBender : Bender
    {
        private double heatAggression;

        public FireBender(string name, int power, double heatAggression)
            : base(name, power)
        {
            this.heatAggression = heatAggression;
        }

        public override double GetPower() => this.heatAggression * this.Power;
    }
}
