namespace NeedForSpeed.Entities.Races
{
    using Cars;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Race
    {
        private int length;
        private string route;
        private int prizePool;
        private Dictionary<int, Car> participants;
        private List<Car> winners;

        public Race(int length, string route, int prizePool)
        {
            this.Lenght = length;
            this.Route = route;
            this.PrizePool = prizePool;
            this.Participants = new Dictionary<int, Car>();
            this.Winners = new List<Car>();
        }

        public int Lenght
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.length = value;
            }
        }

        public string Route
        {
            get
            {
                return this.route;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.route = value;
            }
        }

        public int PrizePool
        {
            get
            {
                return this.prizePool;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.prizePool = value;
            }
        }

        public Dictionary<int, Car> Participants
        {
            get
            {
                return this.participants;
            }
            private set
            {
                this.participants = value;
            }
        }

        public List<Car> Winners {
            get
            {
                return this.winners;
            }
            private set
            {
                this.winners = value;
            }
        }

        public string StartRace()
        {
            var winners = GetWinners();
            var prizes = GetPrizes();

            if (this.participants.Count == 0)
            {
                return "Cannot start the race with zero participants.";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.route} - {this.length}");

            for (int i = 0; i < winners.Count; i++)
            {
                var car = winners.ElementAt(i);
                sb.AppendLine($"{i + 1}. {car.Value.Brand} {car.Value.Model} {this.GetPerformance(car.Key)}PP - ${prizes[i]}");
            }

            return sb.ToString().Trim();
        }

        public abstract int GetPerformance(int id);

        private List<int> GetPrizes()
        {
            var result = new List<int>();
            result.Add((this.prizePool * 50) / 100);
            result.Add((this.prizePool * 30) / 100);
            result.Add((this.prizePool * 20) / 100);

            return result;
        }

        private Dictionary<int, Car> GetWinners() =>
            this.participants
            .OrderByDescending(n => this.GetPerformance(n.Key))
            .Take(3)
            .ToDictionary(n => n.Key, m => m.Value);
    }
}
