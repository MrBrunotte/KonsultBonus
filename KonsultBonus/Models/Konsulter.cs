using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KonsultBonus.Models
{
    public class Konsulter
    {
        [Key]
        [DisplayName("Id")]
        public int KonsultID { get; set; }
        [DisplayName("Förnamn")]
        public string FirstName { get; set; }
        [DisplayName("Efternamn")]
        public string LastName { get; set; }
        [DisplayName("Anställningsdatum")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartingDate { get; set; }
    }
}
