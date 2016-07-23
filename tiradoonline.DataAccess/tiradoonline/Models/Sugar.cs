using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelSugar
    {
        public int SugarID { get; set; }

        public int UserID { get; set; }

        public DateTime SugarDateTime { get; set; }

        public short Sugar { get; set; }

        [StringLength(2000)]
        public string SugarComments { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}
