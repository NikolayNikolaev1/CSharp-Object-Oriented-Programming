namespace Avatar.Entities.Monuments
{
    public class AirMonument : Monument
    {
        private int airAffinity;

        public AirMonument(string name, int airAffinty) 
            : base(name)
        {
            this.airAffinity = airAffinty;
        }

        public override int GetAffinity() => this.airAffinity;

        public override string ToString() => $"{base.ToString()}, Air Affinity: {this.airAffinity}";
    }
}
