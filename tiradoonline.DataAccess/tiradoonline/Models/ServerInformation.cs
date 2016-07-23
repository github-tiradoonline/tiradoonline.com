using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelServerInformation
    {
        public int ServerInformationID { get; set; }

        public int ServerID { get; set; }

        public byte ServerInformationOrderNum { get; set; }

        [Required]
        [StringLength(50)]
        public string ServerInformationName { get; set; }

        public string ServerInformationValue { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Server Server { get; set; }
    }
}
