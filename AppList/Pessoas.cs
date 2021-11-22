using System;
using System.Collections.Generic;
using System.Text;

namespace AppList
{
    public class Pessoas
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "ID: " + Id + ", Nome: " + Name;
        }
    }
}
