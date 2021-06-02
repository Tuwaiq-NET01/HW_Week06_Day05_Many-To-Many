using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class TeacherModel
    {
        public TeacherModel()
        {
            //this.Students = new HashSet<StudentModel>();
        }

        public int Id {set; get;}
        public string FullName { set; get; }
        public string Email { set; get; }

        public ICollection<StudentTeacherModel> Students { set; get; }
    }
}

