using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class roomModel
    {
        public int id { get; set; }
        public string roomType { get; set; }

        [Required]
        public bool empty { get; set; }

        //Navigations proprties
        public int studentId { get; set; } //FK
        public Student student { get; set; }

    }
}
