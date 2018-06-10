namespace Avatar.Entities.Monuments
{
    public class FireMonument : Monument
    {
        private int fireAffinity;

        public FireMonument(string name, int fireAffinity)
            : base(name)
        {
            this.fireAffinity = fireAffinity;
        }
    }
}
