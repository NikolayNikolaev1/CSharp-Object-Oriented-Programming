namespace Avatar.Entities.Benders
{
    public class FireBender : Bender
    {
        private double aerialIntegrity;

        public FireBender(string name, int power, double aerialIntegrity)
            : base(name, power)
        {
            this.aerialIntegrity = aerialIntegrity;
        }
    }
}
