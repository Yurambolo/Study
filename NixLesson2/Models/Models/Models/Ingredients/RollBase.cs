using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class RollBase: Ingredient
    {
        public RollBase(string name, int weight, int cost) : base(name, weight, cost) { }
    }
}