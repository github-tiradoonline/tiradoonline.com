using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelSettings
    {
        public int SettingsID { get; set; }

        public int? UserID { get; set; }

        public bool? DebuggingSetting { get; set; }

        [Required]
        [StringLength(50)]
        public string AdministratorEmail { get; set; }

        [StringLength(200)]
        public string DocumentsDirectory { get; set; }

        [StringLength(200)]
        public string ContactsPhotosDirectory { get; set; }

        [StringLength(200)]
        public string PhotosDirectory { get; set; }

        [StringLength(200)]
        public string MoviesDirectory { get; set; }

        [StringLength(200)]
        public string MusicDirectory { get; set; }

        [StringLength(100)]
        public string SMTPServer { get; set; }

        [StringLength(10)]
        public string SMTPServerPort { get; set; }

        [StringLength(50)]
        public string SMTPServerUserName { get; set; }

        [StringLength(50)]
        public string SMTPServerPassword { get; set; }

        [StringLength(100)]
        public string POP3Server { get; set; }

        [StringLength(10)]
        public string POP3ServerPort { get; set; }

        [StringLength(50)]
        public string POP3ServerUserName { get; set; }

        [StringLength(50)]
        public string POP3ServerPassword { get; set; }

        public string PreviousPage { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}
