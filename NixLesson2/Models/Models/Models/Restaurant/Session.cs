using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class Session
    {
        private int _restaurant;

        public int CurrentUser { get; set; }

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