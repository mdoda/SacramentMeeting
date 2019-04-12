using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13_Sacrament_Planning.Models
{
    public class Speaker
    {
        public int MemberID { get; set; }
        public int MeetingID { get; set; }
        public Member Member { get; set; }
        public Meeting Meeting { get; set; }
        public string Topic { get; set; }
    }
}
