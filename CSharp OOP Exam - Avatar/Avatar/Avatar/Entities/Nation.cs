namespace Avatar.Entities
{
    using System.Collections.Generic;
    using System.Linq;

    public class Nation
    {
        private List<Bender> benders;
        private List<Monument> monuments;

        public Nation()
        {
            this.benders = new List<Bender>();
            this.monuments = new List<Monument>();
        }

        public double GetTotalPower()
        {
            int monumentsIncresePercentage = this.monuments.Sum(m => m.GetAffinity());
            double totalBendersPower = this.benders.Sum(b => b.GetPower());
            double totalPowerIncrese = totalBendersPower / 100 * monumentsIncresePercentage;

            return totalBendersPower + totalPowerIncrese;
        }

        public void AddBender(Bender bender) => this.benders.Add(bender);

        public void AddMonument(Monument monument) => this.monuments.Add(monument);
    }
}
