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

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.route} - {this.length}");
            int counter = 1;


            foreach (var winner in winners)
            {
                if (counter )
                {

                }
            }
        }

        public Dictionary<int, Car> GetWinners() => 
            this.participants
            .OrderByDescending(n => this.GetPerformance(n.Key))
            .Take(3)
            .ToDictionary(n => n.Key, m => m.Value);

        public abstract int GetPerformance(int id);
    }
}
