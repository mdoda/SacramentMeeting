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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Opening Song")]
        public string OpeningHymn { get; set; }

        [Display(Name = "Sacrament Song")]
        public string SacramentHymn { get; set; }

        [Required]
        [Display(Name = "Closing Song")]
        public string ClosingHymn { get; set; }

        [Required]
        [Display(Name = "Opening Prayer")]
        public string OpeningPrayerMember { get; set; }

        [Required]
        [Display(Name = "Closing Prayer")]
        public string ClosingPrayerMember { get; set; }

        [Required]
        [Display(Name = "Conducting")]
        public string BishopricRole { get; set; }

        public List<Speaker> Speakers { get; set; }
    }
}

