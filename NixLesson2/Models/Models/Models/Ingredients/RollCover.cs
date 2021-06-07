using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class RollCover : Ingredient
    {
        public RollCover(string name, int weight, int cost) : base(name, weight, cost) { }
    }
}