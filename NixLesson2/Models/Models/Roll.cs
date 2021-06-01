using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Roll : Dish, IConstructable
    {

        public Roll() : base("Roll", 0, 0)
        {
            Fillers = new IngredientList(3, 7, new List<Type> { Type.GetType("RollFilling") });
            Sauses = new IngredientList(1, 2, new List<Type> { Type.GetType("Sause") });
        }

        public RollBase Base { get; set; }

        public RollCover Cover { get; set; }

        public IngredientList Fillers { get; }

        public IngredientList Sauses { get; }

        public override int Cost
        {
            get
            {
                int sum = 0;
                if (Base != null)
                    sum += Base.Cost;
                if (Cover != null)
                    sum += Cover.Cost;
                foreach (WokFiller filler in Fillers)
                    sum += filler.Cost;
                foreach (Sause sause in Sauses)
                    sum += sause.Cost;
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
                if (Cover != null)
                    sum += Cover.Cost;
                foreach (WokFiller filler in Fillers)
                    sum += filler.Cost;
                foreach (Sause sause in Sauses)
                    sum += sause.Cost;
                return sum;
            }
        }

        public void AddIngridient(Ingredient ingredient)
        {
            switch (ingredient.GetType().ToString())
            {
                case "RollBase":
                    {
                        Base = (RollBase)ingredient;
                        break;
                    }
                case "Cover":
                    {
                        Cover = (RollCover)ingredient;
                        break;
                    }
                case "RollFilling":
                    {
                        Fillers.Add(ingredient);
                        break;
                    }
                case "Sause":
                    {
                        Sauses.Add(ingredient);
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
            if (ingredient.GetType().ToString() == "RollBase")
            {
                Base = (RollBase)ingredient;
                return true;
            }
            return false;
        }

        public bool RemoveIngridient(Ingredient ingredient)
        {
            IngredientList toRemove;
            switch (ingredient.GetType().ToString())
            {
                case "RollFilling":
                    {
                        toRemove = Fillers;
                        break;
                    }
                case "Cover":
                    {
                        Cover = null;
                        return true;
                    }
                case "Sause":
                    {
                        toRemove = Sauses;
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