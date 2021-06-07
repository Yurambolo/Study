using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class Order
    {
        public List<OrderItem> Items { get; set; }

        public float TotalCost { get; set; }

        private float CountCost()
        {
            throw new System.NotImplementedException();
        }
    }
}