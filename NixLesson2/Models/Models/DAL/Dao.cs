using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Models;

namespace Models.DAL
{
    public class Dao
    {
        public Restaurant Restaurant;
        const string filePath = "restaurant.bin"; 
        public Dao(Restaurant restaurant)
        {
            this.Restaurant = restaurant;
        }
        public Dao()
        {
            Load();
        }
        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, Restaurant);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                Restaurant res = (Restaurant)serializer.Deserialize(stream);
                Restaurant = new Restaurant(res);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}