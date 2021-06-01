using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class SoupPreSet : Soup, IPreSet
    {
        public SoupPreSet(string name, int weight, int cost, string description) : base()
        {
            Name = name;
            Weight = weight;
            Cost = cost;
            Description = description;
        }

        public string Description { get; }
    }
}