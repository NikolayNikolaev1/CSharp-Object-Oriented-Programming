namespace Avatar.Entities.Benders
{
    public class WaterBender : Bender
    {
        private double waterClarity;

        public WaterBender(string name, int power, double waterClarity)
            : base(name, power)
        {
            this.waterClarity = waterClarity;
        }
    }
}
