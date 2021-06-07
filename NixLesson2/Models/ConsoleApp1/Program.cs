using System;
using System.Collections.Generic;
using Models;
using Models.DAL;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dao dao = new Dao();
            Restaurant restaurant = dao.Restaurant;
            Wok wok = (Wok)restaurant.Menu.GetDishes()[0];
            Console.WriteLine(wok.Cost);

            //Restaurant restaurant = TestData.fillWithData();
            //Dao dao = new Dao(restaurant);
            //dao.Save();
        }
    }
}
