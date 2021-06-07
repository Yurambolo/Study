using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class OrderItem
    {
        private Dish _dish;

        public int Count { get; set; }
    }
}