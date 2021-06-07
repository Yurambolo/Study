using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class PokePreSet : Poke, IPreSet
    {
        public PokePreSet(string name, int weight, int cost, string description, List<Ingredient> ingredients) : base()
        {
            Name = name;
            Weight = weight;
            Cost = cost;
            Description = description;
            foreach (Ingredient ingredient in ingredients)
            {
                AddIngridient(ingredient);
            }
        }

        public string Description { get; }
    }
}