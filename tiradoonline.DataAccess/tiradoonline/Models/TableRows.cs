using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTableRows
    {
        
        //[Column(Order = 0)]
        [StringLength(50)]
        public string ObjectID { get; set; }

        
        //[Column(Order = 1)]
        [StringLength(50)]
        public string ObjectName { get; set; }

        
        //[Column(Order = 2)]
        [StringLength(50)]
        public string TableOwner { get; set; }

        
        //[Column("TableRows", Order = 3)]
        
        public int TableRows { get; set; }

        
        //[Column(Order = 4)]
        public DateTime create_dt { get; set; }
    }
}
