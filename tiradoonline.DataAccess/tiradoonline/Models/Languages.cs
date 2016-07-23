using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelLanguages
    {
        public int LanguageID { get; set; }

        [Required]
        [StringLength(100)]
        public string Language { get; set; }

        public string ErrorMessage { get; set; }

        public DateTime create_dt { get; set; }
    }
}
