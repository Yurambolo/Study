using System;
using System.Collections.Generic;

namespace Models
{
    [Serializable]
    public class Restaurant
    {
        public readonly Menu Menu;
        private List<Table> _tables;
        private List<Ingredient> _ingredients;
        private List<Visitor> _visitors;
        private List<Reservation> _reservations;
        private List<Order> _orders;

        public List<Reservation> Reservations { get; set; }

        public Restaurant(Menu menu, List<Table> tables, List<Ingredient> ingredients, List<Visitor> visitors, List<Reservation> reservations, List<Order> orders)
        {
            Menu = menu;
            _tables = tables;
            _ingredients = ingredients;
            _visitors = visitors;
            _reservations = reservations;
            _orders = orders;
        }
        public Restaurant(Restaurant restaurant)
        {
            Menu = restaurant.Menu;
            _tables = restaurant._tables;
            _ingredients = restaurant._ingredients;
            _visitors = restaurant._visitors;
            _reservations = restaurant._reservations;
            _orders = restaurant._orders;

        }

        public List<Ingredient> getIngredients()
        {
            return _ingredients;
        }

        public List<Ingredient> getIngredients(string ingredientType)
        {
            List<Ingredient> filteredIngredients = new List<Ingredient>();
            foreach (Ingredient ingredient in _ingredients)
            {
                if (ingredient.GetType().ToString() == ingredientType)
                {
                    filteredIngredients.Add(ingredient);
                }
            }
            return filteredIngredients;
        }

        public Table FindTable()
        {
            throw new System.NotImplementedException();
        }

        public void OptimizeReservations()
        {
            throw new System.NotImplementedException();
        }
    }
}
