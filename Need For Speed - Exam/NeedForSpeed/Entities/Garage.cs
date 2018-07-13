namespace NeedForSpeed.Entities
{
    using System.Collections.Generic;

    public class Garage
    {
        private List<int> parkedCars;

        public Garage()
        {
            this.ParkedCars = new List<int>();
        }

        public List<int> ParkedCars
        {
            get
            {
                return this.parkedCars;
            }
            private set
            {
                this.parkedCars = value;
            }
        }

        public void AddCar(int id) => this.parkedCars.Add(id);

        internal void RemoveCar(int id) => this.parkedCars.Remove(id);
    }
}
