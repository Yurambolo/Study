using System;
using System.Collections.Generic;

namespace Models
{
    public class Restaurant
    {
        private Menu _menu;
        private List<Table> _tables;

        public Visitor CurrentVisitor
        {
            get => default;
            set
            {
            }
        }
    }
}
