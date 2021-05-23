using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Reservation
    {
        private System.DateTime _reservationTime;
        private Visitor _visitor;
        private int _id;

        public System.DateTime ReservedFrom
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime ReservedTill
        {
            get => default;
            set
            {
            }
        }

        public int Status
        {
            get => default;
            set
            {
            }
        }

        public Table Table
        {
            get => default;
            set
            {
            }
        }

        public Order PreOrder
        {
            get => default;
            set
            {
            }
        }
    }
}