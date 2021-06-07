using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class Visitor
    {
        private int _id;
        private int _reputation;

        public System.DateTime Birthday { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Photo { get; set; }
        public Visitor(int id, string name, DateTime birthday, string email, string phone, string photo)
        {
            _id = id;
            Name = name;
            Birthday = birthday;
            Email = email;
            Phone = phone;
            Photo = photo;
        }
    }
}