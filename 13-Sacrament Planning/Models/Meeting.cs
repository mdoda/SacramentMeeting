using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _13_Sacrament_Planning.Models
{
    //TODO the foreign key
    public class Meeting
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime Date { get; set; }

        [Display(Name = "Opening Song")]
        public int OpeningHymnID { get; set; }
        [Display(Name = "Sacrament Song")]
        public int? SacramentID { get; set; }
        [Display(Name = "Closing Song")]
        public int ClosingHymnID { get; set; }

        [Display(Name = "Opening Prayer")]
        public int OpeningPrayerMemberID { get; set; }
        [Display(Name = "Closing Prayer")]
        public int ClosingPrayerID { get; set; }

        [Display(Name = "Conducting")]
        public string BishoppricRole { get; set; }
    }
}

