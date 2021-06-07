using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IConstructable
    {
        void AddIngridient(Ingredient ingredient);
        bool RemoveIngridient(Ingredient ingredient);
        bool ChangeBase(Ingredient ingredient);
    }
}