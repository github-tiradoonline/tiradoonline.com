using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelCollection
    {
        public int CollectionID { get; set; }

        public int CollectionAgencyID { get; set; }

        [StringLength(100)]
        public string CollectionCreditor { get; set; }

        public DateTime CollectionStatementDate { get; set; }

        [StringLength(50)]
        public string CollectionNumber { get; set; }

        [StringLength(100)]
        public string CollectionRepresentative { get; set; }

        
        public decimal CollectionAmount { get; set; }

        [Required]
        [StringLength(2000)]
        public string CollectionNotes { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual CollectionAgency CollectionAgency { get; set; }
    }
}
