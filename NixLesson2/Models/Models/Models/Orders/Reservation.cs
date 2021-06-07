using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class Reservation
    {
        private System.DateTime _reservationTime;
        private Visitor _visitor;
        private int _id;

        public System.DateTime ReservedFrom { get; set; }

        public System.DateTime ReservedTill { get; set; }

        public int Status { get; set; }

        public Table Table { get; set; }

        public Order PreOrder { get; set; }
    }
}