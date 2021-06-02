using System;
using System.ComponentModel.DataAnnotations;
namespace CodeFirst.Models
{
    public class RoomModel
    {
        public int Id { get; set; }


        public int RoomNumber { get; set; }

        [MaxLength(20)]
        public string RoomType { get; set; }

        [Required]
        public bool Empty { get; set; }


        //Navagation Properties
        
        public StudentModel Student { get; set; }
        public int StudentId { get; set; }//FK


    }
}