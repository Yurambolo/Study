using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class Topping: Ingredient
    {
        public Topping(string name, int weight, int cost) : base(name, weight, cost) { }
    }
}