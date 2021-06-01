using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class PokePreSet : Poke, IPreSet
    {
        public PokePreSet(string name, int weight, int cost, string description) : base()
        {
            Name = name;
            Weight = weight;
            Cost = cost;
            Description = description;
        }

        public string Description { get; }
    }
}