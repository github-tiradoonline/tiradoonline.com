using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPersonalInformationCards
    {
        public int PersonalInformationCardID { get; set; }

        [Required]
        [StringLength(100)]
        public string PersonalInformationCard { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<PersonalInformation> PersonalInformation { get; set; }
    }
}
