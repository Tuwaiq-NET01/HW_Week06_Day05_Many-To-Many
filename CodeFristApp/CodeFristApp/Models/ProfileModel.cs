using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFristApp.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string  Image { get; set; }
        public bool  Active { get; set; }

        public CostomerModel Costomer { get; set; }
        // FK
        public int CostomerId { get; set; }
    }
}
