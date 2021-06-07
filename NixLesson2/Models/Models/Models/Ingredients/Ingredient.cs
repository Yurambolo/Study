using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public abstract class Ingredient
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public int Cost { get; set; }

        public Ingredient(string name, int weight, int cost)
        {
            Name = name;
            Weight = weight;
            Cost = cost;
        }
        public override bool Equals(object obj) => this.Equals(obj as Ingredient);

        public bool Equals(Ingredient i)
        {
            return Name == i.Name;
        }

        public override int GetHashCode() => (Name, Weight, Cost).GetHashCode();
    }
}