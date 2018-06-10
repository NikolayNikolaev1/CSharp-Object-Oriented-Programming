namespace Avatar.Entities.Monuments
{
    public class WaterMonument : Monument
    {
        private int waterAffinity;

        public WaterMonument(string name, int waterAffinity)
            : base(name)
        {
            this.waterAffinity = waterAffinity;
        }
    }
}
