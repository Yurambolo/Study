﻿using System;
using System.Collections.Generic;

namespace Models
{
    public class Restaurant
    {
        private Menu _menu;
        private List<Table> _tables;

        public List<Reservation> Reservations
        {
            get => default;
            set
            {
            }
        }

        public void PrintMenu()
        {
            throw new System.NotImplementedException();
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
