using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelWebsiteEmail
    {
        public int WebsiteEmailID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string WebsiteFromEmail { get; set; }

        [Required]
        public string WebsiteEmailBodyText { get; set; }

        public DateTime create_dt { get; set; }
    }
}
