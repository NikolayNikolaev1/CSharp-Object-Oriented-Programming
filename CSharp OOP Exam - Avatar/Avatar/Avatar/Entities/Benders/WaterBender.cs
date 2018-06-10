namespace Avatar.Entities.Benders
{
    public class WaterBender : Bender
    {
        private double aerialIntegrity;

        public WaterBender(string name, int power, double aerialIntegrity)
            : base(name, power)
        {
            this.aerialIntegrity = aerialIntegrity;
        }
    }
}
