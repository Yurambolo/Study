using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public abstract class Dish
    {
        public Dish(string name, int cost, int weight)
        {
            Name = name;
            Weight = weight;
            Cost = cost;
        }
        public virtual int Weight { get; set; }

        public virtual int Cost { get; set; }

        public string Name { get; set; }
    }
}