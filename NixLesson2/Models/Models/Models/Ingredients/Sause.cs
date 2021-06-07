using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class Sause : Ingredient
    {
        public Sause(string name, int weight, int cost) : base(name, weight, cost) { }
    }
}