using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Poke : Dish, IConstructable
    {
        public override int Cost
        {
            get => default;
        }
    }
}