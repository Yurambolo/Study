using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class Table
    {
        private int _id;
        private int _capacity;

        public int Status { get; set; }
        public Table(int id, int capavity)
        {
            _capacity = capavity;
            _id = id;
            Status = 0;
        }
    }
}