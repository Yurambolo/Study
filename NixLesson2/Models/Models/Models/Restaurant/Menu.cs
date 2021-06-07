using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class Menu
    {
        private List<Dish> _dishes;

        public Menu()
        {
            _dishes = new List<Dish>();
        }

        public Menu(List<Dish> dishes)
        {
            _dishes = dishes;
        }

        public List<Dish> GetDishes()
        {
            return _dishes;
        }

        public List<Dish> GetDishes(string dishType)
        {
            List<Dish> filteredDishes = new List<Dish>();
            foreach (Dish dish in _dishes)
            {
                if (dish.GetType().ToString() == dishType)
                {
                    filteredDishes.Add(dish);
                }
            }
            return filteredDishes;
        }
    }
}