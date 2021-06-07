using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class WokBase : Ingredient
    {
        public WokBase(string name, int weight, int cost) : base(name, weight, cost) { }
    }
}