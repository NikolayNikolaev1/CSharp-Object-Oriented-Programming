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
            return this.benders.Sum(b => b.GetPower());
        }
    }
}
