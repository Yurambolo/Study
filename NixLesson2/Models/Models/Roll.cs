using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Roll : Dish, IConstructable
    {
        public override int Cost
        {
            get => default;
        }
    }
}