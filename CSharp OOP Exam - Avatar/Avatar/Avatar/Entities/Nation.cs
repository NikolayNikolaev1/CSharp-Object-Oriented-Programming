﻿namespace Avatar.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

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

        public void DeclareDefeat()
        {
            this.benders.Clear();
            this.monuments.Clear();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Benders:");

            if (this.benders.Any())
            {
                result.AppendLine()
                    .AppendLine(string.Join(Environment.NewLine,
                        this.benders.Select(bender => $"###{bender}")));
            }
            else
            {
                result.AppendLine(" None");
            }

            result.Append("Monuments:");

            if (this.monuments.Any())
            {
                result.AppendLine()
                    .Append(string.Join(Environment.NewLine,
                        this.monuments.Select(monument => $"###{monument}")));
            }
            else
            {
                result.Append(" None");
            }

            return result.ToString();
        }
    }
}
