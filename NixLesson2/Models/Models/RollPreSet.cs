using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class RollPreSet : Roll, IPreSet
    {
        public RollPreSet(string name, int weight, int cost, string description) : base()
        {
            Name = name;
            Weight = weight;
            Cost = cost;
            Description = description;
        }

        public string Description { get; }
    }
}