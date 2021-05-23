using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Order
    {
        public List<OrderItem> Items
        {
            get => default;
            set
            {
            }
        }

        public float TotalCost
        {
            get => default;
            set
            {
            }
        }

        private float CountCost()
        {
            throw new System.NotImplementedException();
        }
    }
}