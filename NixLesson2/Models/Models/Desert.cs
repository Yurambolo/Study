using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Desert : Dish, IPreSet
    {
        public Desert(string name, int weight, int cost, string description) : base(name, cost, weight)
        {
            Description = description;
        }

        public string Description { get; }
    }
}