using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class SubjectModel
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public TeacherModel Teacher { set; get; }
        public int TeacherId { set; get; }
    }
}
