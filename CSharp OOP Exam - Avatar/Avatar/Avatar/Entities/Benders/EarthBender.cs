namespace Avatar.Entities.Benders
{
    public class EarthBender : Bender
    {
        private double aerialIntegrity;

        public EarthBender(string name, int power, double aerialIntegrity)
            : base(name, power)
        {
            this.aerialIntegrity = aerialIntegrity;
        }
    }
}
