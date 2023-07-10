using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalNursery.Models.Comands
{
    public class Comand
    {
        
        public string Name { get; set; }

        public Command(string item) { 
            Name = item;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}