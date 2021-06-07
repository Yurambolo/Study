using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class SoupBase : Ingredient
    {
        public SoupBase(string name, int weight, int cost) : base(name, weight, cost) { }
    }
}