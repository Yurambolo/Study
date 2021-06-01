using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class HotDrink : Dish, IPreSet
    {
        public HotDrink(string name, int weight, int cost, string description) : base(name, cost, weight)
        {
            Description = description;
        }

        public string Description { get; }
    }
}