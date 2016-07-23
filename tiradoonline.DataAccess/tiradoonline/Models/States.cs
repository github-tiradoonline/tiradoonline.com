using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelStates
    {
        public int StateID { get; set; }

        [StringLength(30)]
        public string State { get; set; }

        [StringLength(2)]
        public string StateAbbr { get; set; }

        public string ErrorMessage { get; set; }
                                           //public virtual ICollection<Hospital> Hospital { get; set; }


        //public virtual ICollection<Pharmacy> Pharmacy { get; set; }


        //public virtual ICollection<ZipCode> ZipCode { get; set; }
    }
}
