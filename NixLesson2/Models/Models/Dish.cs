using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Dish
    {
        public virtual int Weight { get; set; }

        public virtual int Cost { get; set; }

        public string Name { get; set; }
    }
}