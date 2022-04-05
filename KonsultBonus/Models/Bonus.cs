using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace KonsultBonus.Models
{
    public class Bonus
    {
        [DisplayName("Netto resultat")]
        public double NettoResultat { get; set; }

        [DisplayName("Total bonuspott")]
        public double Bonuspott { get; set; }

        [DisplayName("Antal år i firman")]
        public double NumberOfYearsInFirm { get; set; }

        [DisplayName("Debiterade timmar")]
        public double DebiteradeTimmar { get; set; }

        [DisplayName("Bonus andel i %")]
        public double BonusProcent { get; set; }

        [DisplayName("Bonus i kr")]
        public double BonusKr { get; set; }
    }
}
