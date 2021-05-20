using System;

namespace ClassLibrary1
{
    public class User
    {
        string _name;
        int _age = 18;

        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { if (value >= 0) _age = value; } }

        public User() : this("User") { }

        public User(string name) : this(name, 19)
        {
            Name = name;
        }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"User \'{Name}\' is {Age} years old!";
        }

        public void isAdult()
        {
            Console.WriteLine(Age >= 18 ? $"User \'{Name}\' is adult!" : $"User \'{Name}\' is not adult!");
        }
    }
}
