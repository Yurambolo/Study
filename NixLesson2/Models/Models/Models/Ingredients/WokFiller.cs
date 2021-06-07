using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class WokFiller : Ingredient
    {
        public WokFiller(string name, int weight, int cost) : base(name, weight, cost) { }
    }
}