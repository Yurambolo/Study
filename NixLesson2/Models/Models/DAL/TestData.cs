using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Models.DAL
{
    public static class TestData
    {
        public static Restaurant fillWithData()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new WokBase("Udon", 100, 30));
            Sause sause = new Sause("Teriyaki", 10, 6);
            ingredients.Add(sause);
            ingredients.Add(new WokFiller("Carrot", 40, 8));
            ingredients.Add(new WokFiller("Pepper", 40, 10));
            ingredients.Add(new WokFiller("Onion", 40, 8));
            ingredients.Add(new Protein("Chicken", 70, 18));
            List<Dish> dishes = new List<Dish>();
            dishes.Add(new WokPreSet("MyWok1", 300, 80, "My first Wok", ingredients));
            dishes.Add(new ColdDrink("Lemonade", 300, 40, "Frresh cool lemonade"));
            Menu menu = new Menu(dishes);
            List<Table> tables = new List<Table>();
            tables.Add(new Table(0, 4));
            tables.Add(new Table(1, 6));
            tables.Add(new Table(2, 6));
            List<Visitor> visitors = new List<Visitor>();
            visitors.Add(new Visitor(0, "Ivan", new DateTime(2002,07,28), null, null, null));
            List<Reservation> reservations = new List<Reservation>();
            List<Order> orders = new List<Order>();
            Restaurant restaurant = new Restaurant(menu,tables,ingredients,visitors, reservations,orders);
            return restaurant;
        }
    }
}
