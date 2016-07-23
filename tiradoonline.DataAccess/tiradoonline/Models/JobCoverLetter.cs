using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelJobCoverLetter
    {
        public int JobCoverLetterID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string JobCoverLetterName { get; set; }

        [Required]
        public string JobCoverLetterText { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}
