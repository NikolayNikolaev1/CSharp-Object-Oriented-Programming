namespace Avatar.Entities.Benders
{
    public class EarthBender : Bender
    {
        private double groundSaturation;

        public EarthBender(string name, int power, double groundSaturation)
            : base(name, power)
        {
            this.groundSaturation = groundSaturation;
        }
    }
}
