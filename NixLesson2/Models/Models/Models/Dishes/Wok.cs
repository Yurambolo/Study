using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class Wok : Dish, IConstructable
    {
        public Wok() : base("Wok", 0, 0)
        {
            Fillers = new IngredientList(3, 7, new List<string> { "WokFiller"});
            Proteins = new IngredientList(0, 3, new List<string> { "Protein" });
            Sauses = new IngredientList(1, 2, new List<string> { "Sause" });
            Toppings = new IngredientList(0, 2, new List<string> { "Topping" });
        }
        public WokBase Base { get; private set; }

        public IngredientList Fillers { get; }

        public IngredientList Proteins { get; }

        public IngredientList Sauses { get; }

        public IngredientList Toppings { get; }

        public override int Cost
        {
            get
            {
                int sum = 0;
                if (Base != null)
                    sum += Base.Cost;
                foreach (WokFiller filler in Fillers)
                    sum += filler.Cost;
                foreach (Protein protein in Proteins)
                    sum += protein.Cost;
                foreach (Sause sause in Sauses)
                    sum += sause.Cost;
                foreach (Topping topping in Toppings)
                    sum += topping.Cost;
                return sum;
            }
        }

        public override int Weight
        {
            get
            {
                int sum = 0;
                if (Base != null)
                    sum += Base.Cost;
                foreach (WokFiller filler in Fillers)
                    sum += filler.Cost;
                foreach (Protein protein in Proteins)
                    sum += protein.Cost;
                foreach (Sause sause in Sauses)
                    sum += sause.Cost;
                foreach (Topping topping in Toppings)
                    sum += topping.Cost;
                return sum;
            }
        }

        public void AddIngridient(Ingredient ingredient)
        {
            switch (ingredient.GetType().Name)
            {
                case "WokBase":
                    {
                        Base = (WokBase)ingredient;
                        break;
                    }
                case "WokFiller":
                    {
                        Fillers.Add(ingredient);
                        break;
                    }
                case "Protein":
                    {
                        Proteins.Add(ingredient);
                        break;
                    }
                case "Sause":
                    {
                        Sauses.Add(ingredient);
                        break;
                    }
                case "Topping":
                    {
                        Toppings.Add(ingredient);
                        break;
                    }
                default:
                    {
                        throw new Exception();
                    }
            }
        }

        public bool ChangeBase(Ingredient ingredient)
        {
            if (ingredient.GetType().ToString() == "WokBase")
            {
                Base = (WokBase)ingredient;
                return true;
            }
            return false;
        }

        public bool RemoveIngridient(Ingredient ingredient)
        {
            IngredientList toRemove;
            switch (ingredient.GetType().ToString())
            {
                case "WokFiller":
                    {
                        toRemove = Fillers;
                        break;
                    }
                case "Protein":
                    {
                        toRemove = Proteins;
                        break;
                    }
                case "Sause":
                    {
                        toRemove = Sauses;
                        break;
                    }
                case "Topping":
                    {
                        toRemove = Toppings;
                        break;
                    }
                default:
                    {
                        return false;
                    }
            }
            return toRemove.Remove(ingredient);
        }
    }
}