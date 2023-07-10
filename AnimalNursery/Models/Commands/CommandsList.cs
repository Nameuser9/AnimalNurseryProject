using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalNursery.Models.Comands
{
    public class CommandsList
    {
       public List<Command> _commands;

        public CommandsList() {
            _commands = new List<Command>();
        } 
        
        public string ConvertToString() {
            return string.Join(", ", _commands);
        }

        public void ToList(string item) {
            var s = item.Split(", ");
            foreach (String c in s){
                Command cm = new Command(c);
                
                _commands.Add(cm);
            }
        }

    }  
    }
