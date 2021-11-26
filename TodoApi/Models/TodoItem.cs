using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; } // Chave exclusiva em um banco relacional
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
