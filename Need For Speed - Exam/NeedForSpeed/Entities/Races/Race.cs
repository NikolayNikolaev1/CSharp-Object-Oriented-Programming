namespace NeedForSpeed.Entities.Races
{
    using Cars;
    using System;
    using System.Collections.Generic;

    public abstract class Race
    {
        private int length;
        private string route;
        private int prizePool;
        private List<Car> participants;

        public Race(int length, string route, int prizePool)
        {
            this.Lenght = length;
            this.Route = route;
            this.PrizePool = prizePool;
            this.Participants = new List<Car>();
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

        public List<Car> Participants {
            get
            {
                return this.participants;
            }
            private set
            {
                this.participants = value;
            }
        }
    }
}
