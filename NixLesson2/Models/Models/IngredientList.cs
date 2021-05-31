using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class IngredientList : IList<Ingredient>
    {
        private Ingredient[] _ingredients = new Ingredient[10];
        private int _count;
        private int _maxIngredients;
        private int _minIngredients;
        private List<Type> _allowedIngredients;
        public IngredientList(int maxIngredients, int minIngredients, List<Type> allowedIngredients)
        {
            MaxIngredients = maxIngredients;
            MinIngredients = minIngredients;
            _allowedIngredients = allowedIngredients;
        }
        public int MaxIngredients { get => _maxIngredients; set { _maxIngredients = value >= 0 && value <= 10 ?  value : throw new Exception(); } }
        public int MinIngredients { get => _minIngredients; set { _minIngredients = value >= 0 && value <= 10 ? value : throw new Exception(); } }
        public Ingredient this[int index] { get => _ingredients[index]; set => _ingredients[index] = value; }

        public int Count => _count;

        public bool IsReadOnly => false;

        public void Add(Ingredient item)
        {
            if (_count < _maxIngredients && _allowedIngredients.Contains(item.GetType()))
            {
                _ingredients[_count] = item;
                _count++;
            }
            else
            {
                throw new Exception();
            }
        }

        public void Clear()
        {
            _count = 0;
        }

        public bool Contains(Ingredient item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_ingredients[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Ingredient[] array, int arrayIndex)
        {
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(_ingredients[i], arrayIndex++);
            }
        }

        public IEnumerator<Ingredient> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(Ingredient item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_ingredients[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, Ingredient item)
        {
            if ((_count + 1 <= _ingredients.Length) && (index < Count) && (index >= 0))
            {
                _count++;

                for (int i = Count - 1; i > index; i--)
                {
                    _ingredients[i] = _ingredients[i - 1];
                }
                _ingredients[index] = item;
            }
        }

        public bool Remove(Ingredient item)
        {
            int i = IndexOf(item);
            if (i != -1)
            {
                RemoveAt(i);
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _ingredients[i] = _ingredients[i + 1];
                }
                _count--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}