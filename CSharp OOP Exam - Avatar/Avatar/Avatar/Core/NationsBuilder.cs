namespace Avatar.Core
{
    using Avatar.Entities.Benders;
    using Entities;
    using System;
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

        public void AssignBender(List<string> benderArgs)
        {
            string benderType = benderArgs[0];

            Bender currentBender = this.GetBender(benderArgs);
            this.nations[benderType].AddBender(currentBender);
        }

        private Bender GetBender(List<string> benderArgs)
        {
            string benderType = benderArgs[0];
            string benderName = benderArgs[1];
            int benderPower = int.Parse(benderArgs[2]);
            double benderAuxParam = double.Parse(benderArgs[3]);

            switch (benderType)
            {
                case "Air":
                    return new AirBender(benderName, benderPower, benderAuxParam);
                case "Fire":
                    return new FireBender(benderName, benderPower, benderAuxParam);
                case "Water":
                    return new WaterBender(benderName, benderPower, benderAuxParam);
                case "Earth":
                    return new EarthBender(benderName, benderPower, benderAuxParam);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
