namespace Avatar.Core
{
    using Entities;
    using System.Collections.Generic;

    public class NationsBuilder
    {
        private Dictionary<string, Nation> nations;

        public NationsBuilder()
        {
            this.nations = new Dictionary<string, Nation>()
            {
                { "Air", new Nation()},
                { "Fire", new Nation()},
                { "Water", new Nation()},
                { "Earth", new Nation()}
            };
        }
    }
}
