using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelWeight
    {
        public int WeightID { get; set; }

        public int UserID { get; set; }

        public DateTime WeightDateTime { get; set; }

        [StringLength(100)]
        public string WeightLocation { get; set; }

        [StringLength(2000)]
        public string WeightComments { get; set; }

        public DateTime create_dt { get; set; }
    }
}
