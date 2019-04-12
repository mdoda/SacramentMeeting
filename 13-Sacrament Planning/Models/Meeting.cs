using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _13_Sacrament_Planning.Models
{
    //TODO the foreign key
    public class Meeting
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime Date { get; set; }

        [Display(Name = "Opening Song")]
        public string OpeningHymnID { get; set; }

        [Display(Name = "Sacrament Song")]
        public string SacramentHymn { get; set; }

        [Display(Name = "Closing Song")]
        public string ClosingHymn { get; set; }

        [Display(Name = "Opening Prayer")]
        public string OpeningPrayerMember { get; set; }

        [Display(Name = "Closing Prayer")]
        public string ClosingPrayerMember { get; set; }

        [Display(Name = "Conducting")]
        public string BishopricRole { get; set; }

        public List<Speaker> Speakers { get; set; }
    }
}

