using System;
namespace MVC_DB.Models
{
    public class StudnetModel
    {

        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        //
        public RoomModel Room { get; set; }

    }
}
