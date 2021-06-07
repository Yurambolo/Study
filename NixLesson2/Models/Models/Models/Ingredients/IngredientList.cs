using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class IngredientList : IList<Ingredient>, IEnumerable
    {
        private Ingredient[] _ingredients = new Ingredient[10];
        private int _count;
        private int _maxIngredients;
        private int _minIngredients;
        private List<string> _allowedIngredients;
        public IngredientList(int minIngredients, int maxIngredients, List<string> allowedIngredients)
        {
            MaxIngredients = maxIngredients;
            MinIngredients = minIngredients;
            _allowedIngredients = allowedIngredients;
        }
        public int MaxIngredients { get => _maxIngredients; set { _maxIngredients = value >= 0 && value <= 10 ?  value : throw new Exception(); } }
        public int MinIngredients { get => _minIngredients; set { _minIngredients = value >= 0 && value <= 10 ? value : throw new Exception(); } }
        public new Ingredient this[int index] { get => _ingredients[index]; set => _ingredients[index] = value; }

        public new int Count => _count;

        public bool IsReadOnly => false;

        public new void Add(Ingredient item)
        {
            if (_count < _maxIngredients && _allowedIngredients.Contains(item.GetType().Name))
            {
                _ingredients[_count] = item;
                _count++;
            }
            else
            {
                throw new Exception();
            }
        }

        public new void Clear()
        {
            _count = 0;
        }

        public new bool Contains(Ingredient item)
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

        public new void CopyTo(Ingredient[] array, int arrayIndex)
        {
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(_ingredients[i], arrayIndex++);
            }
        }

        public new int IndexOf(Ingredient item)
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

        public new void Insert(int index, Ingredient item)
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

        public new bool Remove(Ingredient item)
        {
            int i = IndexOf(item);
            if (i != -1)
            {
                RemoveAt(i);
                return true;
            }
            return false;
        }

        public new void RemoveAt(int index)
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
            return (IEnumerator)GetEnumerator();
        }

        public new IngredientEnum GetEnumerator()
        {
            Ingredient[] temp = new Ingredient[_count];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _ingredients[i];
            }
            return new IngredientEnum(temp);
        }

        IEnumerator<Ingredient> IEnumerable<Ingredient>.GetEnumerator()
        {
            //Ingredient[] temp = new Ingredient[_count];
            //for (int i = 0; i < _count; i++)
            //{
            //    temp[i] = _ingredients[i];
            //}
            //return (IEnumerator<Ingredient>)new IngredientEnum(temp);
            return (IEnumerator<Ingredient>)GetEnumerator();
        }
    }
    public class IngredientEnum : IEnumerator
    {
        public Ingredient[] _ingredients;
        int position = -1;

        public IngredientEnum(Ingredient[] list)
        {
            _ingredients = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _ingredients.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Ingredient Current
        {
            get
            {
                try
                {
                    return _ingredients[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}