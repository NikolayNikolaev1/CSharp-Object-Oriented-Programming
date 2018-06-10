﻿namespace Avatar.Entities.Monuments
{
    public class AirMonument : Monument
    {
        private int airAffinity;

        public AirMonument(string name, int airAffinty) 
            : base(name)
        {
            this.airAffinity = airAffinty;
        }
    }
}