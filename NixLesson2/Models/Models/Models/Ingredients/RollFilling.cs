using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class RollFilling : Ingredient
    {
        public RollFilling(string name, int weight, int cost) : base(name, weight, cost) { }
    }
}