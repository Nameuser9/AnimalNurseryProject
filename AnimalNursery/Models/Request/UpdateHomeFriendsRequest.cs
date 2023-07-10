using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalNursery.Models.Request
{
    public class UpdateHomeFriendsRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Commands { get; set; }
        public string Type { get; set; }
    }
}