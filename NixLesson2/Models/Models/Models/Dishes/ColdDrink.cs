using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class ColdDrink : Dish, IPreSet
    {
        public ColdDrink(string name, int weight, int cost, string description) : base(name, cost, weight) 
        {
            Description = description;
        }

        public string Description { get; }
    }
}