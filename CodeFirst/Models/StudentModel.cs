using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class StudentModel
    {
        public StudentModel()
        {
            //this.Teachers = new HashSet<TeacherModel>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public RoomModel Room { get; set; }

        public ICollection<StudentTeacherModel> Teachers { set; get; }

    }
}
