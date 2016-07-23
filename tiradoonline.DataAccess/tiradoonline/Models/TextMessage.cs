using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTextMessage
    {
        public int TextMessageID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string TextMessageFromEmail { get; set; }

        //[Column("TextMessage")]
        [Required]
        public string TextMessage { get; set; }

        public DateTime create_dt { get; set; }
    }
}
