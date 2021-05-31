using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Soup : Dish, IConstructable
    {
        public override int Cost
        {
            get => default;
        }
    }
}