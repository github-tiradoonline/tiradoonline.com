using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelReminders
    {
        
        public int ReminderID { get; set; }

        public int UserID { get; set; }

        public DateTime ReminderDateTime { get; set; }

        [Required]
        [StringLength(200)]
        public string ReminderName { get; set; }

        public string ReminderDescription { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}
