using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class RollPreSet : Roll, IPreSet
    {
        public RollPreSet(string name, int weight, int cost, string description, List<Ingredient> ingredients) : base()
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