using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ColdDrink : Dish, IPreSet
    {
        public ColdDrink(string name, int weight, int cost, string description, bool hasIce) : base(name, cost, weight) 
        {
            Description = description;
            HasIce = hasIce;
        }

        public string Description { get; }

        public bool HasIce { get; set; }
    }
}