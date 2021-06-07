using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class Protein : Ingredient
    {
        public Protein(string name, int weight, int cost) : base(name, weight, cost) { }
    }
}