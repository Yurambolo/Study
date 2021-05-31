using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Ingredient
    {
        public string Name
        {
            get => default;
            set
            {
            }
        }

        public int Weight
        {
            get => default;
            set
            {
            }
        }

        public int Cost
        {
            get => default;
            set
            {
            }
        }
        public override bool Equals(object obj) => this.Equals(obj as Ingredient);

        public bool Equals(Ingredient i)
        {
            return Name == i.Name;
        }

        public override int GetHashCode() => (Name, Weight, Cost).GetHashCode();
    }
}