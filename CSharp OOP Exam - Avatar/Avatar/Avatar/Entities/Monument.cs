using System;

namespace Avatar.Entities
{
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
    }
}
