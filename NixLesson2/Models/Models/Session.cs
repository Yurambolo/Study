using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Session
    {
        private int _restaurant;

        public int CurrentUser
        {
            get => default;
            set
            {
            }
        }

        public Visitor Register()
        {
            throw new System.NotImplementedException();
        }

        public Visitor SignIn()
        {
            throw new System.NotImplementedException();
        }

        public void MakeReservation()
        {
            throw new System.NotImplementedException();
        }
    }
}