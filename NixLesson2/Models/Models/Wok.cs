using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Wok : Dish, IConstructable
    {
        public Wok()
        {
            throw new System.NotImplementedException();
        }

        public WokBase Base
        {
            get => default;
            set
            {
            }
        }

        public List<WokFiller> Fillers
        {
            get => default;
            set
            {
            }
        }

        public List<Protein> Proteins
        {
            get => default;
            set
            {
            }
        }

        public List<Sause> Sauses
        {
            get => default;
            set
            {
            }
        }

        public List<Topping> Toppings
        {
            get => default;
            set
            {
            }
        }

        public override int Cost
        {
            get 
            {
                int sum = 0;
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
    }
}