﻿namespace Avatar.Entities
{
    using System;

    public abstract class Monument
    {
        private string name;

        public Monument(string name)
        {
            this.name = name;
        }

        public string Name {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public abstract int GetAffinity();

        public override string ToString()
        {
            string monumentType = this.GetType().Name;
            int typeEnd = monumentType.IndexOf("Monument");
            monumentType = monumentType.Insert(typeEnd, " ");

            return $"{monumentType}: {this.Name}";
        }
    }
}
