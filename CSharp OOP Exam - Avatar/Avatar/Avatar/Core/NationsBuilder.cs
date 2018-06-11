namespace Avatar.Core
{
    using Entities.Benders;
    using Entities.Monuments;
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

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

        public void AssignMonument(List<string> monumentArgs)
        {
            string monumentType = monumentArgs[0];

            Monument currentMonument = this.GetMonument(monumentArgs);
            this.nations[monumentType].AddMonument(currentMonument);
        }

        public string GetStatus(string nationsType)
        {
            StringBuilder message = new StringBuilder();

            message.AppendLine($"{nationsType} Nation")
                .Append(this.nations[nationsType]);

            return message.ToString();
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

        private Monument GetMonument(List<string> monumentArgs)
        {
            string monumentType = monumentArgs[0];
            string monumentName = monumentArgs[1];
            int monumentAffinity = int.Parse(monumentArgs[2]);

            switch (monumentType)
            {
                case "Air":
                    return new AirMonument(monumentName, monumentAffinity);
                case "Fire":
                    return new FireMonument(monumentName, monumentAffinity);
                case "Water":
                    return new WaterMonument(monumentName, monumentAffinity);
                case "Earth":
                    return new EarthMonument(monumentName, monumentAffinity);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
