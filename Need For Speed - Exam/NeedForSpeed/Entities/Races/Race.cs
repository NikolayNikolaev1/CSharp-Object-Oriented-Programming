namespace NeedForSpeed.Entities.Races
{
    using Cars;
    using System.Collections.Generic;

    public abstract class Race
    {
        private int length;
        private string route;
        private int prizePool;
        private List<Car> participants;

        public Race(int length, string route, int prizePool)
        {
            this.length = length;
            this.route = route;
            this.prizePool = prizePool;
            this.participants = new List<Car>();
        }
    }
}
