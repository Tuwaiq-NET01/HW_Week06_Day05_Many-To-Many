using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFristApp.Models
{
    public class CostomerModel
    {  
        public int Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ProfileModel Profile { get; set; }

        public List<CostomerProductModel> CostomerProduct { get; set; }

    }
}
