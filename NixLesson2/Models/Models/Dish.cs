﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Dish
    {
        public int Weight
        {
            get => default;
            set
            {
            }
        }

        public abstract int Cost { get;}

        public int Name
        {
            get => default;
            set
            {
            }
        }
    }
}